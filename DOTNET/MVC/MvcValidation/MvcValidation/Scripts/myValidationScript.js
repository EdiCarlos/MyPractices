<reference path="jquery.validate.js" />
<reference path="jquery.validate.unobtrusive.js" />

    jQuery.validator.addMethod("oneoftworequired", function (value, element, param) {
        if ($("#Phone").val() == '' && $("#Mobile").val() == '')
            return false;
        else
            return true;
    });

    jQuery.validator.unobtrusive.adapters.addBool("oneoftworequired");

    var refreshValidation = function () {
        var formToRefresh = $('form');
        formToRefresh.each(function () {
            var form = $(this);
            form.removeData('validator');
            $.validator.unobtrusive.parse(form);
        });
    };

    
    refreshValidation();
