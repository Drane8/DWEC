"use strict";

$("#final").click(function () {
    $("#lista").children().last().remove();
});
$("#princ").click(function () {
    $("#lista").children().first().remove();
});
$("#1y2").click(function () {
    $("#lista").children().eq(0).remove();
    $("#lista").children().eq(0).remove();
});
$("#3y4").click(function () {
    $("#lista").children().eq(2).remove();
    $("#lista").children().eq(2).remove();
});
$("#par").click(function () {
    $("#lista").children().eq(1).remove();
    $("#lista").children().eq(2).remove();
});
$("#impar").click(function () {
    $("#lista").children().eq(0).remove();
    $("#lista").children().eq(1).remove();
});
$("#el2").click(function () {
    $("#lista").children().eq(1).remove();
});
