"use strict";

let tabla="<table id=\"listado\">\n" +
    "                <tr>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                </tr>\n" +
    "                <tr>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                </tr>\n" +
    "                <tr>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                </tr>\n" +
    "                <tr>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                </tr>\n" +
    "                <tr>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                    <td>Hola</td>\n" +
    "                </tr>\n" +
    "            </table>";

window.addEventListener("load",()=>{
    $("#contenido").append(tabla);
    $("#listado tr:nth-child(odd)").children().mouseover(function () {
       $(this).append("*");
    });
});
