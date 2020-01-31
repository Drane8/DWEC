"use strict";

let tabla = "<table>";
for(let i=0; i<8; i++){
    tabla += "<tr id='fila-"+(i+1)+"'><td></td></tr>";
}
tabla += "</table><br/>";
 window.onload = function () {
    $("#tabla").append(tabla);
 };

$("#pintar").click(function () {
    $("tr#fila-3").prevAll().css("background-color","red");
    $("tr#fila-3").nextAll().css("background-color","blue");
});
