//Burda biz modalin acib baglanmai ile bagli odlarimizi yaziriq. Bunu ScriptsPartiala qosmuruq spesifik olaraq bize lazim olan
//Folderlerdeki Indexlerine qosuruq (Mes: Views/Category-Index.cshtml ), cunki modal her yerde lazim olmaya biler

showInPopup = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (response) {
            $('#form-modal .modal-body').html(response);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
            const container = document.getElementById('form-modal');
            var forms = container.getElementsByTagName('form'); // Burdaki 3 setir bizde eger modalin setirleri valid deyilse heein mesajin submitden once ele biz yaza - yaza gorsenmesini temin edir
            var newForm = forms[forms.length - 1];
            $.validator.unobtrusive.parse(newForm);
        },
        error: function (error) {
            console.log(error);
        }
    });
}


function clearModal() {
    $('#form-modal .modal-body').html('');
    $('#form-modal .modal-title').html('');
    $('#form-modal').modal('hide');
}

// #region A
//
// server ve client side validation olur. Hal hazirda bizde server side validation movcuddur. Biz modali submit edende geir request
// atir ve bu requeste gore 1 ede partiali render edib qaytarir, amma moalstatesi valid deyilse bizim backendimiz imkan vermirki yeni
// row yaransin error gostersin.Burda bir mesel varki bu prosese(server side validation) request atildiqdan sonra bas verir yeni bir nov
// refresh gedir.Biz indi ona gore cient - side validation elave edeceyikki isimiz asanlassin, refreshin qarsissi alinsin.AMMA Server side
// validation da mutleq olmalidir, cunki client side validationu hack - leyib kecmek olar, amma serverside validationda bu mumkun deyil.
// Niye bele olur ? cunki client - side yazdqimiz kodlar gorsenir, browserden onlara baxmaq olar.amma server - side tam olaraq back - end ile
// elaqeli olduqu ucun o kodlar gorsenmir.
//
// #endregion A