"use strict";

let imagenes = ["img/1.jpg", "img/2.jpg", "img/3.jpg", "img/4.jpg", "img/5.jpg",
    "img/6.jpg", "img/7.jpg", "img/8.jpg", "img/9.jpg", "img/10.jpg"];
let fotoActual = 0;

document.getElementById("ant").addEventListener("click",anteriorFoto);

document.getElementById("sig").addEventListener("click",siguienteFoto);

function siguienteFoto() {
    fotoActual++;
    if(fotoActual >= imagenes.length){
        fotoActual = 0;
    }
    mostrar(fotoActual);
}

function anteriorFoto(){
    fotoActual--;
    if(fotoActual < 0){
        fotoActual = imagenes.length - 1;
    }
    mostrar(fotoActual);
}


function mostrar(foto){
    document.getElementById("resul").setAttribute("src",imagenes[foto]);
}
mostrar(fotoActual);
setInterval(siguienteFoto,4000);