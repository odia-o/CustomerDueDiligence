$(document).ready(function () {
    $("#logOff").on('click', function () {
        var form = $('#logoutForm');
        var token = $('input[name="__RequestVerificationToken"]', form).val();
        $.ajax({
            url: '/Account/LogOff',
            type: 'POST',
            data: {
                __RequestVerificationToken: token,
            },
            success: function (result) {
                window.location.reload();
            }
        });
        return false;
    });



    var customers = new Bloodhound({
        datumTokenizer: Bloodhound.tokenizers.obj.whitespace('firstname'),
        queryTokenizer: Bloodhound.tokenizers.whitespace,
        remote: {
            url: '/api/customers?query=%QUERY',
            wildcard: '%QUERY'
        }
    });

    $('#cu').typeahead({
        minLength: 3,
        highlight: true
    }, {
            name: 'customers',
            display: 'firstname',
            source: customers
        }).on("typeahead:select", function (e, customer) {

        });
});