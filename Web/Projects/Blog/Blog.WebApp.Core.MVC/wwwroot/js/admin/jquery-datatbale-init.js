// Bu .js filesini biz sirf data table ile baqi JS kodlarimizi yazacayiq ve layout sehifemize qosacayiqki tekrar tekrar yazmali olmayaq 
// (layout deyende _Layout.cshtml qosulmus _ScriptsPartial.cshtml - den gedir.)

let dataTable;

$(document).ready(function () {
    dataTable = $("#dataTable").DataTable(); // ???????????????
})


function insertedRowToDataTable(entity, rowItem) { // rowitem, tr-leri obyekt formasinda getirir. Yeni evvel yazdiqimiz helper methoddan
                                                   // sadece bununla ferqlenir.
    const row = dataTable.row.add(rowItem).node();
    console.log(dataTable.row.add(rowItem).node()); 
    console.log(dataTable.row.add(rowItem));
    // ?? .node() menasi??
    const rowObj = $(row); // row-nu jQuery obyektine ceviririk
    rowObj.attr('name', `${entity.Id}`); // Buna atribut elave edirik. Bunu ona gore edirikki her elemeti unic-lesdirek ve sonra hemen 
                                         // datani rahatliqla goture bilek
    dataTable.row(rowObj).draw(); // draw methodu bir nov dataTableni refresh edir. (yeni row-u datatable de gorsenmesini temin edir)
}

function updateDataTableRow(entity, currentRow, rowItem) { // currenRow yeni hansi row-a click olunubsa onu getiri
    dataTable.row(currentRow).data(rowItem).node();
    currentRow.attr('name', `${entity.Id}`);
    dataTable.row(currentRow).invalidate(); // burda biz draw() methodu istifade etmedik, cunki bize yeni raw draw olunmasi lazim deyil.
                                            // Hazir rowdaki datalarin update olunmasi lazimfir ki bu isi de biz invalidate() methodu ile
                                            // rahatliqla edirik
}


