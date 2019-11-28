"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let env = document.getElementById("env");
env.addEventListener("click", () => {
    alert("Nombre: " + document.getElementById("nom").value +
        "\nApellidos: " + document.getElementById("ap1").value + " " +
        document.getElementById("ap2").value);
});