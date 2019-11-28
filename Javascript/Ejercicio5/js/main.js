"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let env = document.getElementById("env");
env.addEventListener("click", () => {
    let mar = document.getElementById("mar");
    let tam = document.getElementById("tam");
    if (tam.value === "") {
        alert("Seleccione un tamaño");
    } else {
        alert("Ha elegido " + mar.value + " de " + tam.value);
    }
});