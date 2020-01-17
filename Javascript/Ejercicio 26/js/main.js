"use strict";


var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
let ancho= canvas.width = window.innerWidth;
let alto =canvas.height = window.innerHeight;
let texto= prompt("Introduzca texto","texto a mostrar");
ctx.font = "30px Arial";
let anchoTexto = 0;
let total= 1;
let letrasFin= false;

class Letra {
    constructor(letra) {
        this.letra = letra;
        this.posX = ancho + anchoTexto;
        this.posY = 40;
    };
}

let letras = [];
for(let i = 0; i < texto.length;i++){
    letras.push(new Letra(texto.charAt(i)));
    anchoTexto += ctx.measureText(letras[i].letra).width;
}

function dibujar(){
    ctx.fillStyle = "#FFFFFF";
    ctx.fillRect(0, 0, ancho, alto);
    for(let i = 0; i < total; i++){
        ctx.fillStyle = "#000000";
        if( letras[0].posX - 5 <= 0){
            letrasFin = true;
        }else{
            letras[i].posX -= 5;
        }
        ctx.fillText(letras[i].letra,letras[i].posX,letras[i].posY);

    }

    if(letrasFin){
        clearInterval(moviendo);
    }

    if(total < texto.length)
    {
        total++
    }
}

let moviendo= setInterval(dibujar,250);