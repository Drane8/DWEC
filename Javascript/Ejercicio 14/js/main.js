"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let quitar = document.getElementById("quitarEspacios");
quitar.addEventListener("click",()=>{
    let frase = document.getElementById("frase");
    //frase.value = frase.value.split(" ").join("");
    frase.value = frase.value.replace(/\s/g,"");
});