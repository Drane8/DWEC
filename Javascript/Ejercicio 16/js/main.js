"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let usuarios = ["Manolo", "Pedro", "Maria", "Luisa", "Pepe"];
let passwords = ["12345", "asd123", "contraseña", "101219", "P3pe"];

function datosCorrectos(usuario, pass) {
    let indice = usuarios.indexOf(usuario);
    if (indice < 0) {
        alert("El usuario introducido es incorrecto");
    } else if (passwords[indice] !== pass) {
        alert("La contraseña introducida es incorrecta");
    } else {
        return true;
    }
    return false;
}

function vaciarCampos(){
    document.getElementById("usu").value = "";
    document.getElementById("pass").value = "";
}

let log = document.getElementById("log");
log.addEventListener("click", () => {
    let usuario = document.getElementById("usu").value;
    let pass = document.getElementById("pass").value;
    if (datosCorrectos(usuario, pass)) {
        alert("Login correcto");
        vaciarCampos();
    }
});

let add = document.getElementById("add");
add.addEventListener("click", () => {
    let usuario = document.getElementById("usu").value;
    let pass = document.getElementById("pass").value;
    if (usuarios.includes(usuario)) {
        alert("El nombre de usuario ya esta en uso");
    }else if (pass === ""){
        alert("Introduzca una contraseña");
    } else {
            usuarios.push(usuario);
            passwords.push(pass);
            alert("Usuario añadido correctamente");
            vaciarCampos();
    }
});

let del = document.getElementById("del");
del.addEventListener("click", () => {
    let usuario = document.getElementById("usu").value;
    let pass = document.getElementById("pass").value;
    if (datosCorrectos(usuario, pass)) {
        if(confirm("¿Estas seguro de que quieres borrar al usuario: " + usuario +"?")) {
            let indice = usuarios.indexOf(usuario);
            usuarios.splice(indice, 1);
            passwords.splice(indice, 1);
            alert("Usuario borrado correctamente");
            vaciarCampos();
        }
    }
});

let list = document.getElementById("list");
list.addEventListener("click", () => {
    let usuariosOrdenados = usuarios.slice();
    let resul = "Usuarios: ";
    usuariosOrdenados.sort();
    usuariosOrdenados.forEach((usuario) => {
        resul += "\n" + usuario;
    });
    alert(resul);
});