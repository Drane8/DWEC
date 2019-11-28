"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let env = document.getElementById("env");
env.addEventListener("click", () => {
    alert("Usuario: " + document.getElementById("usu").value +
        "\nClave: " + document.getElementById("pass").value);
});