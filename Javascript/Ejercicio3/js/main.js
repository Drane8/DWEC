"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let env = document.getElementById("env");
env.addEventListener("click", () => {
    let resul = "Nombre: " + document.getElementById("nom").value +
        "\nApellidos: " + document.getElementById("ap").value;

    let genero = document.getElementsByName("genero");
    genero.forEach((genero) => {
        if (genero.checked) {
            resul += "\nGenero: " + genero.value;
        }
    });
    resul += "\nAficiones:";
    let aficiones = document.getElementsByName("aficiones");
    aficiones.forEach((aficion) => {
        if (aficion.checked) {
            resul += " " + aficion.value;
        }
    });
    alert(resul);
});