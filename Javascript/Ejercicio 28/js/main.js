"use strict";

let fecha = new Date();
let subasta = false;
let tiempo = -1;
let ofertaPrev = 0;
let tiempoRestante = new Date(null);
document.getElementById("hora").innerHTML = fecha.toLocaleTimeString();


let enviar = document.getElementById("env");
enviar.disabled = true;
enviar.addEventListener("click", () => {
    let oferta = document.getElementById("oferta").value;
    if (isNaN(oferta)) {
        alert("Oferta no valida");
    } else {
        if (oferta <= ofertaPrev) {
            alert("La oferta es menor o igual que la anterior");
        } else {
            ofertaPrev = oferta;
            document.getElementById("pujas").innerHTML += "<li>" + oferta + "€</li>";
        }
    }

});

document.getElementById("subasta").addEventListener("click", () => {
    document.getElementsByName("tiempo").forEach((segundos) => {
        if (segundos.checked) {
            tiempo = segundos.value;
        }
    });
    tiempoRestante = new Date(null);
    tiempoRestante.setSeconds(tiempo);
    enviar.disabled = false;
    document.getElementById("subasta").disabled = true;
    subasta = true;
});

function actualizar() {
    fecha = new Date();
    document.getElementById("hora").innerHTML = fecha.toLocaleTimeString();
    if (subasta) {
        tiempo--;
        tiempoRestante = new Date(null);
        tiempoRestante.setSeconds(tiempo); // specify value for SECONDS here
        var timeString = tiempoRestante.toISOString().substr(11, 8);
        document.getElementById("tiempo").innerHTML = timeString;

        if (tiempo === 0) {
            alert("Puja ganadora: " + ofertaPrev +"€");
            document.getElementById("pujas").innerHTML = "";
            enviar.disabled = true;
            document.getElementById("subasta").disabled = false;
            subasta = false;
            tiempo --;
        }
    }
}

setInterval(actualizar, 1000);