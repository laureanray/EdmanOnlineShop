// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready( function() {
    $(document).on('change', '.btn-file :file', function() {
        var input = $(this),
            label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
        input.trigger('fileselect', [label]);
    });

    $('.btn-file :file').on('fileselect', function(event, label) {

        var input = $(this).parents('.input-group').find(':text'),
            log = label;

        if( input.length ) {
            input.val(log);
        } else {
            if( log ) alert(log);
        }

    });
    function readURL(input) {
        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                $('#img-upload').attr('src', e.target.result);
            }

            reader.readAsDataURL(input.files[0]);
        }
    }

    $("#imgInp").change(function(){
        readURL(this);
    });
    
    try {
        $("#products_table").DataTable({
            columnDefs: [ {
                targets: [1,2],
                render: function ( data, type, row ) {
                    return type === 'display' && data.length > 40 ?
                        data.substr( 0, 40 ) +'…' :
                        data;
                }
            } ]
        });
        $("#categories_table").DataTable();
    }catch(err){
        console.log('not datatable');
    }
    
    $('.price').each(function(){
        var price = $(this).html().trim();
        var new_price = formatMoney(price);
        $(this).html(new_price);
    });
    
    $(".product-name-card").each(function(){
        $clamp(this, {clamp: 2} );
    });

    $(".card-product").show();


    // $(".product-price").html(formatMoney($(".product-price").html()));
});

function formatMoney(n, c, d, t) {
    var c = isNaN(c = Math.abs(c)) ? 2 : c,
        d = d == undefined ? "." : d,
        t = t == undefined ? "," : t,
        s = n < 0 ? "-" : "",
        i = String(parseInt(n = Math.abs(Number(n) || 0).toFixed(c))),
        j = (j = i.length) > 3 ? j % 3 : 0;

    return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
};
