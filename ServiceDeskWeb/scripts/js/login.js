$(document).ready(function () {
    //$('h2').addClass('animated slideInLeft');
    //$('.fmLogin').addClass('animated slideInRight');
    $('.modal').modal();
});
$("#btnEntrar").click(function () {
    $("#modalLoad").modal('open');
});