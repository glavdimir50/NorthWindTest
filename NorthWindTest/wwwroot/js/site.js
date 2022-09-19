// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
Ajax = {
    Request: function (url, data, successHandler, errorHandler, method) {
        $.ajax({
            cache: false,
            url: url,
            data: data,
            dataType: "json",
            method: method,
            success: successHandler,
            error: errorHandler ? errorHandler : this.errorHandler,
            complete: function (jqXHR, textStatus) {
                
            }
        });
    },
    errorHandler: function (jqXHR) { console.log(jqXHR); }
};