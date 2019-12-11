"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let frase = document.getElementById("frase");
soloLetras(frase);

let caracter = document.getElementById("caracter");
caracter.maxLength = 1;
soloLetras(caracter);

let quitar = document.getElementById("eliminarCaracter");
quitar.addEventListener("click", () => {
    frase.value = frase.value.split(caracter.value).join("");
    caracter.value = "";
});

function soloLetras(campo) {
    let funciones = ["input", "paste", "keydown", "keyup"];
    funciones.forEach((evento) => {
        campo.addEventListener(evento, () => {
            campo.value = campo.value.replace(/[^a-zA-Z]+/, '');
        })
    });
}