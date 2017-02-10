//Business Logic


//User Interface Logic
$(function(){
    $("#submit").click(){
        var fields = ["contact-name", "contact-phone-number", "contact-address"];
        for (i = 0; i < fields.length; i++) {
            if ( !$("#" + i).val() ) {
                $(this).parent().addClass("has-danger");
                return false;
            }
        }
    }
})
