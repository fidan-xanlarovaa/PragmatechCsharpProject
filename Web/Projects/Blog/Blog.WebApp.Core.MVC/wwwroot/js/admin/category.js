////// AJAX-sin isi client terfede javaScript vasitesi ile back-endimize sorqu atmaqdir. Yeni biz bura GET ve POST sorqulari gonderirik,
//////controllerimizden de buna uyqun arxaya json bir data qaytaririrq
$(document).ready(function () {

    /* $('#entitiesDataTable').DataTable();*/
    //#region  dataTable
    $('#entitiesDataTable').DataTable({
        "bServerSide": false,
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {
                text: 'Create',
                attr: {
                    id: "btnCreate"
                },
                className: 'btn',
                action: function (e, dt, node, config) {
                    /*alert('Button create');*/
                }
            },
            {
                text: 'Refresh',
                className: 'btn btn-warning',
                action: function (e, dt, node, config) {
                    alert('Button refresh');
                }
            }
        ],
        "bDestroy": true
    });

    //#endregion  dataTable


    //#region modal and create

    $(function () {

        const url = 'Category/Create'
        const modalPlaceHolderDiv = $('#modalPlaceHolder'); // index sehifesinde modali yerlesdireceyimiz div

        $('#btnCreate').click(
            function () {
                $.get(url).done(function (response) { // Controllerden Create-nin get-ini gotururuk o da bize create partial viewsunu qaytarir
                    modalPlaceHolderDiv.html(response); // Goturduyumuz partiali index sehifesinde yerlesdiririk
                    modalPlaceHolderDiv.find('.modal').modal('show'); // gorsensin deye show parametrin veririk
                })
            }
        )

        //#region create : ajax. post
        modalPlaceHolderDiv.on('click',
            '#btnSave',
            function (event) {
                event.preventDefault(); // button avtomatik refresh etme funksiyasinin qarsini alir
                //
                const form = $('#form'); // formu tapir

                const actionUrl = form.attr('action'); // formun actionununun adini tapir (meselen: "Category/Create")
                console.log(actionUrl);

                const data = form.serialize(); // formdaki butun datalari yiqib getirir
                console.log(data);

                $.post(actionUrl, data) // Uyqun Controllerin Postuna gedir ve datani oturur
                    .done(function (response) {
                        const viewModel = response;
                        const formBody = $('.modal-body', viewModel.partial);
                        modalPlaceHolderDiv.find('.modal-body').replaceWith(formBody);
                        const isValid = formBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            modalPlaceHolderDiv.find('.modal').modal('hide');
                            const entity = viewModel.dto.entity;
                            // yeni row hazirlayiriq
                            const newTableRowString = createNewRowStringTemplate(entity);
                            const newTableRowObject = $(newTableRowString);
                            newTableRowObject.hide();
                            $('#entitiesDataTable').append(newTableRowObject);
                            newTableRowObject.fadeIn(2500);
                            toastr.success(`${viewModel.dto.message}`, 'Success');
                        } else {
                            let summaryText = '\r\n';
                            $('#validationSummary > ul > li').each(function () {
                                let text = $(this).text();
                                summaryText += `\r\n*${text}\r\n`;
                            });
                            toastr.warning(summaryText);
                        }
                    });

            });
    });

    //#endregion create : ajax. post

    //#endregion modal and create

    //#region update
    $(function () {
        const url = 'Category/Update';
        const modalPlaceHolderDiv = $('#modalPlaceHolder');
        $(document).on('click', '.btn-update', function (event) {
            event.preventDefault();
            const id = $(this).attr('data-id');
            // ajax. getting partial view
            $.get(url, { id: id })
                .done(function (response) {
                    modalPlaceHolderDiv.html(response);
                    modalPlaceHolderDiv.find('.modal').modal('show');
                })
                .fail(function () {
                    toastr.error('Error!');
                });
        });
        //#region update : ajax. post
        modalPlaceHolderDiv.on('click',
            '#btnUpdate',
            function (event) {
                event.preventDefault();
                const form = $('#form');
                const actionUrl = form.attr('action');
                const data = form.serialize();
                $.post(actionUrl, data)
                    .done(function (response) {
                        const viewModel = response;
                        const formBody = $('.modal-body', viewModel.partial);
                        modalPlaceHolderDiv.find('.modal-body').replaceWith(formBody);
                        const isValid = formBody.find('[name="IsValid"]').val() === 'True';
                        if (isValid) {
                            modalPlaceHolderDiv.find('.modal').modal('hide');
                            const entity = viewModel.dto.entity;
                            // template literals
                            const newTableRowString = createNewRowStringTemplate(entity);
                            const newTableRowObject = $(newTableRowString);
                            console.log(`newRow`);
                            console.log(newTableRowObject);
                            newTableRowObject.hide();
                            const currentRow = $(`[name="${entity.id}"]`);
                            console.log(`currentRow`);
                            console.log(currentRow);
                            currentRow.replaceWith(newTableRowObject);
                            newTableRowObject.fadeIn(3500);
                            toastr.success(`${viewModel.dto.message}`, 'Success');
                        } else {
                            let summaryText = '';
                            $('#validationSummary > ul > li').each(function () {
                                let text = $(this).text();
                                summaryText = `* ${text}\n`;
                            });
                            toastr.warning(summaryText);
                        }
                    })
                    .fail(function (response) {

                    });
            });
        //#endregion ajax. post
    });
    //#endregion update

    //#region deleted 
    $(document).on('click', '.btn-delete',
        function () {
            event.preventDefault();
            const id = $(this).attr('data-id');
            const tableRow = $(`[name=${id}]`);
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
                    $.ajax({
                        type: 'POST',
                        dataType: 'json',
                        data: { id: id },
                        url: 'Category/Delete',
                        success: function (response) {
                            if (response.resultStatus === 0) {
                                Swal.fire(
                                    'Deleted!',
                                    `${response.message}`,
                                    'success'
                                );
                                tableRow.fadeOut(3000);
                            } else {
                                Swal.fire({
                                    icon: 'error',
                                    title: 'Error!',
                                    text: `${response.message}`
                                });
                            }
                        },
                        error: function (error) {
                            console.log(error);

                        }
                    });

                }
            });
        });
    //#endregion

    //#region helper
    function createNewRowStringTemplate(entity) {
        const newTableRowString = `<tr name="${entity.id}">
                                                            <td>
                                                                 <a class="btn text-primary btn-sm btn-update" data-id="${entity.id}"><i class='fa fa-edit'></i></a>
                                                                 <a class="btn text-danger btn-sm btn-delete" data-id="${entity.id}"><i class="fa fa-trash"></i></a>
                                                            </td>
                                                            <td>${entity.id}</td>
                                                            <td>${entity.name}</td>
                                                            <td>${entity.description}</td>
                                                            <td>${convertFirstLetterToUpperCase(entity.isDeleted.toString())}</td>
                                                            <td>${convertFirstLetterToUpperCase(entity.isActive.toString())}</td>
                                                            <td>${convertToShortDate(entity.createdDate)}</td>
                                                            <td>${entity.createdByName}</td>
                                                            <td>${convertToShortDate(entity.modifiedDate)}</td>
                                                            <td>${entity.modifiedByName}</td>
                                                        </tr>`;
        return newTableRowString;
    }
    //#endregion helper


});