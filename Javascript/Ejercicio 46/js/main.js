"use strict";

const tamTablero = 16;
let totalOcas = 3;
let totalPozos = 3;
let tablero = new Array(tamTablero);


let inicioPartida = false;
let turno = 'fichaAzul';
let fin = false;


tablero[tablero.length - 1] = "finOca.png";

for (let i = 0; i < totalOcas; i++) {
    let random = Math.floor(Math.random() * tamTablero);
    do {
        random = Math.floor(Math.random() * tamTablero);
    } while (typeof tablero[random] !== 'undefined');
    tablero[random] = "oca.png";
}

for (let i = 0; i < totalPozos; i++) {
    let random = Math.floor(Math.random() * tamTablero);
    do {
        random = Math.floor(Math.random() * tamTablero);
    } while (typeof tablero[random] !== 'undefined');
    tablero[random] = "pozo.gif";
}

let tabla = "<table id='tablero'><tr><td id='salida'></td>";

for (let i = 0; i < tamTablero; i++) {
    tabla += "<td>" + (typeof tablero[i] !== 'undefined' ? "<img src='img/" + tablero[i] + "'/>" : '') + "</td>";
}

tabla += "</tr></table>";


window.addEventListener("load", () => {
    $("#contenido").append(tabla);
    $("#salida").css("border", 'none');
    $("#salida").append("<span class='ficha' id='fichaRoja' casilla='0'></span>");
    $("#fichaRoja").css("background", "red");
    $("#salida").append("<span class='ficha' id='fichaAzul' casilla='0'></span>");
    $("#fichaAzul").css("background", "blue");

    $("#contenido").append("<button id='comenzar'>Comenzar partida</button>");


    function jugarTurno() {
        let dado = Math.floor(Math.random() * 6) + 1;
        $("#resul").append("</br>Has sacado un: " + dado);
        let ficha = $("#" + turno);
        let casilla = parseInt(ficha.attr('casilla')) + dado;
        casilla = casilla > tamTablero ? tamTablero - (casilla - tamTablero) : casilla;
        ficha.css({"-webkit-transform": "translate(" + (casilla * 63 + 10) + "px,0)"}).css('transition', 'all 2s');
        setTimeout(() => {
            switch (tablero[casilla - 1]) {
                case 'pozo.gif':
                    ficha.attr('casilla', 0);
                    casilla = 0;
                    ficha.css({"-webkit-transform": "translate(" + (casilla * 63 + 10) + "px,0)"}).css('transition', 'all 2s');
                    $("#resul").append("</br>Has caido en el pozo, vuelve a empezar");
                    cambiarTurno();
                    break;
                case 'oca.png':
                    let oca = tablero.indexOf('oca.png', casilla) + 1;
                    if (oca !== 0) {
                        ficha.css({"-webkit-transform": "translate(" + (oca * 63 + 10) + "px,0)"}).css('transition', 'all 2s');
                        ficha.attr('casilla', oca);
                    } else {
                        ficha.attr('casilla', casilla);
                    }
                    $("#resul").append("</br>De oca a oca y tiro por que me toca");
                    break;
                case 'finOca.png':
                    fin = true;
                    break;
                default:
                    ficha.attr('casilla', casilla);
                    cambiarTurno();
                    break;
            }
        }, 2500);
        setTimeout(()=>{

            $("#resul").text("Turno de: " + turno);
        },5001)
    }

    function cambiarTurno() {
        switch (turno) {
            case 'fichaAzul':
                turno = 'fichaRoja';
                break;
            case 'fichaRoja':
                turno = 'fichaAzul';
                break;

        }
    }

    $("#comenzar").click(function (ev) {
        ev.preventDefault();
        if (!inicioPartida) {
            $(this).text("Tirar dado");
            inicioPartida = true;
            $("#resul").text("Turno de: " + turno);
        } else {
            $(this).attr("disabled", true);
            jugarTurno();
            setTimeout(() => {
                $(this).removeAttr("disabled")
            }, 5001);
            setTimeout (()=>{
                if(fin){
                    let ganador = "";
                    ganador = turno === "fichaAzul" ? "azul" : "rojo";
                    $("#resul").text("").append("Fin de la partida<br> Ha ganado el jugador "+ganador);
                    $(this).attr("disabled", true).text("FIN PARTIDA");

                }
            },5100);
        }

    });


});
