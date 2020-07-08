(function ($) {
    $.validator.unobtrusive.addValidation = function (selector) {
        //get the relevant form 
        var form = $(selector);
        // delete validator in case someone called form.validate()
        $(form).removeData("validator");
        $.validator.unobtrusive.parse(form);
    }
}