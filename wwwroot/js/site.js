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
        $("#feedbacks_table").DataTable();
        $("#request_table").DataTable();
        $("#users_table").DataTable();

        $("#categories_table").DataTable();
        $("#orders_table").DataTable({
            columnDefs: [ {
                targets: 0,
                render: function ( data, type, row ) {
                    return type === 'display' && data.length > 70 ?
                        data.substr( 0, 70 ) +'…' :
                        data;
                }
            } ]
        });
        $("#archived_table").DataTable({
            columnDefs: [ {
                targets: 2,
                render: function ( data, type, row ) {
                    return type === 'display' && data.length > 70 ?
                        data.substr( 0, 70 ) +'…' :
                        data;
                }
            } ]
        });
        $("#orders_table").show();
        $("#categories_table").show();
        $("#products_table").show();
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
    
    
    var pathname = window.location.pathname;
    console.log(pathname);
    $("#products_link, #cart_link, #register_link, #login_link, #my_order_link, #feedbacks_link, #request_link").removeClass('edman_active');
    switch(pathname)
    {
        case "/Products":
            $("#products_link").addClass('edman-active');
            break;
        case "/Identity/Account/Login":
            $("#login_link").addClass('edman-active');
            break;
        case "/Identity/Account/Register":
            $("#register_link").addClass("edman-active");
            break;
        case "/Cart":
            $("#cart_link").addClass('edman-active');
            break;
        case "/Orders/MyOrders":
            $("#my_order_link").addClass('edman-active');
            break;
        case "/Feedbacks":
            $("#feedbacks_link").addClass('edman-active');
            break;
        case "/Request":
            $("#request_link").addClass('edman-active');
            break;
    }
    

    $("#payment_method").change(function(){
        var value = $(this).val();
        if(value === "CASH_ON_DELIVERY")
        {
            $(".creditCardForm").hide();
            $("#confirm_payment").removeAttr('disabled');
        }else{
            $(".creditCardForm").show();
            $("#confirm_payment").attr('disabled', 'disabled')
        }
    });
    // $(".date-only").html(moment($(".date-only").html()).format('LL'));

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
