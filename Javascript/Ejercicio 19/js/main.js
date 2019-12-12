"use strict";

let valores = [true, 5, false, "hola", "adios", 2, false,
    "pepe", 73, "juan", "22", 0];
let booleanos = 0;
let numericos = 0;
let suma = 0;
let strings = 0;
let empiezaVocal = 0;
valores.forEach((valor)=>{
   if(typeof valor === 'boolean'){
       booleanos++;
   }
    if(typeof valor === 'number'){
        numericos++;
        suma+=valor;
    }
    if(typeof valor === 'string'){
        strings++;
        if(valor.match(/^[aeiou]/i)){
            empiezaVocal++;
        }
    }
});
document.getElementById("resul").innerHTML = "Valores: " + valores +
    "<br/>Booleanos: " + booleanos + "<br/>Numericos: " + numericos +
    "<br/>Suma: " + suma + "<br/>Strings: " + strings +
    "<br/>Empiezan por vocal: " + empiezaVocal;