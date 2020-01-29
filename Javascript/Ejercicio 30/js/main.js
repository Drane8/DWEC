"use strict";
let listaOriginal = $('\n' +
    '        <li>Primer item</li>\n' +
    '        <li>Segundo item</li>\n' +
    '        <li>Tercer item</li>\n' +
    '        <li>Cuarto item</li>');
$("#remLis").click(function () {
    $("#lista").children().remove();
});
$("#resLis").click(function () {
    $("#lista").children().remove();
    $("#lista").append(listaOriginal);
});
$("#addFin").click(function () {
    $("#lista").append('<li>Elemento al final</li>');
});
$("#addPri").click(function () {
    $("#lista").prepend('<li>Elemento al principio</li>');
});
$("#remFin").click(function () {
    $("#lista").children().last().remove();
});
$("#remPri").click(function () {
    $("#lista").children().first().remove();
});
$("#rem1y2").click(function () {
    $("#lista").children().first().remove();
    $("#lista").children().first().remove();
});
$("#remUlt2").click(function () {
    $("#lista").children().last().remove();
    $("#lista").children().last().remove();
});
