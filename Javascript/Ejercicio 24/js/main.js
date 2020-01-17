"use strict";

localStorage.clear();
document.getElementById("add").addEventListener("click", () => {
    let pelicula = document.getElementById("pelicula").value;
    localStorage.setItem(pelicula, "");
    mostrar();
});

document.getElementById("rem").addEventListener("click", () => {
    let nombre = prompt("Introduzca la perricula a eliminar");
    localStorage.removeItem(nombre);
    mostrar();
});

function mostrar() {
    let resul = "";
    for (let i = 0; i < localStorage.length; i++) {
        resul += "<li>" + localStorage.key(i) + "</li>"
    }
    document.getElementById("resul").innerHTML = resul;
}
