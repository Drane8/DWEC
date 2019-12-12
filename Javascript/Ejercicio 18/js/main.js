"use strict";

let numeros = [];
for(let i = 0; i < 6; i++){
    numeros.push(Math.floor(Math.random() * (49)) + 1);
}
numeros.sort((a, b)=>{return a-b});
document.getElementById("resul").innerHTML = numeros;
