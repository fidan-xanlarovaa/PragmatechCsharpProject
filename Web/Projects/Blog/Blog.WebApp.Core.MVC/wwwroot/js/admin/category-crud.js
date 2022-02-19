jqueryAjaxPost = form => {

    try {
        const $form = $(form);
        if ($form.valid()) {
            $.ajax({
                type: 'POST',
                url: form.action,
                data: new FormData(form),
                contentType: false,
                processData: false,
                success: function (response) {

                    $('#form-modal .modal-body').html(response.partial); // urlden qayidan response, yeni url-in return-inden gelen data

                    const isValid = $('#form-modal .modal-body').find('[name="IsValid"]').val() === 'True';

                    if (isValid) {

                        clearModal(); // Biz gormesekde sehifede ust-uste modallar yaranir ve bu ozu problemli bir seydir. Ona gore de
                                      // eger validdirse ilk iw modali silmeliyik

                        const entity = response.result.data; 

                        if (response.action) // create // Bunu CategoryCreateAjaxVieModel-de olan Action propertysine gore teyin edirik
                            // Burda heriflerin balaca CategoryCreateAjaxVieModel-da boyuk olmasinin sebebi C# ve 
                            // Javascript sintaksindadir.Ve Newton Soft ile biz bu ferqlilikleri aradan qaldirib her dilin oz sintaksina 
                            // uyqunlasdiririq.
                        {
                            insertedRowToDataTable(entity, makeDataTableRowObj(entity)); // helper method
                        } else // update
                        {
                            const currentRow = $(`[name="${entity.id}"]`);
                            updateDataTableRow(entity, currentRow, makeDataTableRowObj(entity));
                        }
                        toastr.success(`${response.result.message}`, 'Success');
                    } else {
                        validationSummary();
                    }
                },
                error: function (error) {
                    toastr.error(error.responseText, 'Fail!');
                }
            });
        }
        // to prevent default form submit event. Modalstate valid olmayanda datani dala qaytarmamalidi bunun ucun biz ya bele yazmaliyiq
        // ya da en yuxarda event.preventDefault(); qeyd etmeliyik
        return false;
    } catch (e) {
        console.log(e);
    }
    // to prevent default form submit event
    return false;
}


jQueryAjaxDelete = currentRow => {
    event.preventDefault();
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            try {
                const id = $(currentRow).attr('data-id');
                const deletedRow = $(`[name=${id}]`);
                $.ajax({
                    type: 'POST',
                    dataType: 'json',
                    data: { id: id },
                    url: 'Category/Delete',
                    success: function (response) {
                        if (response.isSuccess) {
                            Swal.fire(
                                'Deleted!',
                                `${response.message}`,
                                'success'
                            );
                            deletedRow.fadeOut(3000); // 3 saniye icinde bu row-u yoxa cixart
                        } else {
                            Swal.fire({
                                icon: 'error',
                                title: 'Error!',
                                text: `${response.message}`
                            });
                        }
                    },
                    error: function (error) {
                        toastr.error(error.responseText, 'Fail!');
                    }
                });
            } catch (e) {

            }
        }
    });
}


//#region heplers
function makeDataTableRowObj(entity) {
    return [
        `
             <a class='btn text-primary btn-sm btn-update' onclick="showInPopup('Category/Update?id=${entity.id}','Update')" data-id="${entity.id}"><i class='fa fa-edit'></i></a>
             <a class='btn text-danger btn-sm btn-delete' onclick="jQueryAjaxDelete(this)" data-id="${entity.id}"><i class="fa fa-trash"></i></a>
             `,
        entity.id,
        entity.name,
        entity.description,
        convertFirstLetterToUpperCase(entity.isDeleted.toString()),
        convertFirstLetterToUpperCase(entity.isActive.toString()),
        convertToShortDate(entity.createdDate),
        entity.createdByName,
        convertToShortDate(entity.modifiedDate),
        entity.modifiedByName
    ];
}

function validationSummary() { // Modal state valid deyilse ordaki ul oxuyub bize gostersin (error metodudur)
    let summaryText = '';
    $('#validationSummary > ul > li').each(function () {
        let text = $(this).text();
        summaryText += `*${text} \n`;
    });
    toastr.warning(summaryText);
}
//#endregion

//function createNewRowStringTemplate(entity) {
//    const newTableRowString = `<tr name="${entity.id}">
//                                                            <td>
//                                                                 <a class="btn text-primary btn-sm btn-update" data-id="${entity.id}"><i class='fa fa-edit'></i></a>
//                                                                 <a class="btn text-danger btn-sm btn-delete" data-id="${entity.id}"><i class="fa fa-trash"></i></a>
//                                                            </td>
//                                                            <td>${entity.id}</td>
//                                                            <td>${entity.name}</td>
//                                                            <td>${entity.description}</td>
//                                                            <td>${convertFirstLetterToUpperCase(entity.isDeleted.toString())}</td>
//                                                            <td>${convertFirstLetterToUpperCase(entity.isActive.toString())}</td>
//                                                            <td>${convertToShortDate(entity.createdDate)}</td>
//                                                            <td>${entity.createdByName}</td>
//                                                            <td>${convertToShortDate(entity.modifiedDate)}</td>
//                                                            <td>${entity.modifiedByName}</td>
//                                                        </tr>`;
//    return newTableRowString;
//}