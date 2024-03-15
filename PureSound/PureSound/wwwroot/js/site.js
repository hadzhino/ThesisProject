$(document).ready(function () {
    $('#exampleModal').on('shown.bs.modal', function () {
        $('#exampleInput').trigger('focus');
    });
});
$('#exampleModal').appendTo("body")