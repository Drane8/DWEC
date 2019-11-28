"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let env = document.getElementById("env");
env.addEventListener("click", () => {
    let resul = "";
    let extremadura = document.getElementsByName("extremadura");
    extremadura.forEach((provincia) => {
        if (provincia.checked) {
            resul += "Provincia de Extremadura seleccionada: " + provincia.value;
        }
    });
    let cValen = document.getElementsByName("cValen");
    cValen.forEach((provincia) => {
        if (provincia.checked) {
            resul += "\nProvincia de C.Valenciana seleccionada: " + provincia.value;
        }
    });
    alert(resul);
});