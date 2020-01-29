"use strict";

let tabla = "<table>";
for(let i=0; i<3; i++){
    tabla += "<tr>";
    for(let j=0;j<7;j++){
        tabla += "<td>";
        if(Math.random() >= 0.5){
            tabla+="X";
        }
        tabla+="</td>"
    }
    tabla +="</tr>";
}
tabla += "</table><br/>";
 window.onload = function () {
    $("#tabla").append(tabla);
 };

$("#pintar").click(function () {
    $("td:empty").css("background-color","yellow");
});
