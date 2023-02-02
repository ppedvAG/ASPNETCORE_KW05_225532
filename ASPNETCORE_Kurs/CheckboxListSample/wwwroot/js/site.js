// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $('#btnSubmit').on('click', function () {
        $.ajax({
            url: '/CourseSelection',
            type: 'POST',
            data: $('#CoursesForm').serialize(),
            success: function (response) {
                console.log('Success');
            },
            error: function (xhr) {
                console.log(xhr);
            }
        })
    });
});