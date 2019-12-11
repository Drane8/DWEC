"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";
form.setAttribute("onsubmit", "return validar()");

function validar() {
    let nombre = document.getElementById("nom").value;
    let direccion = document.getElementById("dir").value;
    let poblacion = document.getElementById("pob").value;
    let codigoPostal = document.getElementById("cop").value;
    let pais = document.getElementById("pai").value;
    let edad = document.getElementById("eda").value;
    let preferencias = "";
    let sexo = "";

    document.getElementsByName("genero").forEach((genero) => {
        if (genero.checked) {
            sexo = genero.value;
        }
    });
    
    document.getElementsByName("preferencias").forEach((preferencia) => {
        if (preferencia.checked) {
            preferencias += preferencia.value + " ";
        }
    });

    if (!/^\d+$/.test(codigoPostal) || parseInt(codigoPostal) < 1000 || parseInt(codigoPostal) > 52999) {
        alert("Introduzca un codigo postal valido");
    } else if (pais === "") {
        alert("Seleccione pais");
    } else if (sexo === "") {
        alert("Seleccione sexo");
    } else if (!/^\d+$/.test(edad) || parseInt(edad) < 0 || parseInt(edad) > 120) {
        alert("Introduzca una edad valida");
    } else if (preferencias === "") {
        alert("Seleccione sus preferencias");
    } else {
        alert("Nombre: " + nombre + "\nDireccion: " + direccion + "\nPoblacion: " + poblacion +
            "\nCodigo Postal: " + codigoPostal + "\nPais: " + pais + "\nGenero: " + sexo +
            "\nEdad: " + edad + "\nPreferencias: " + preferencias);
        return true;
    }
    return false;
}