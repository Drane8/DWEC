"use strict";

$("#cabeceraParrafo").click(function () {
    $("#parrafo").slideToggle();
});

$("#cabeceraParrafo").mouseover(function () {
    $("#cabeceraParrafo").css("background-color","blue");
    $("#parrafo").css("background-color","blue");
});

$("#cabeceraParrafo").mouseout(function () {
    $("#cabeceraParrafo").css("background-color","red");
    $("#parrafo").css("background-color","red");

});
