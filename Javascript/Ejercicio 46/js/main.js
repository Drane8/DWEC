"use strict";

const tamañoTablero = 12;
let totalOcas = 2;
let totalPozos = 2;
let tablero = new Array(tamañoTablero);


tablero[tablero.length - 1] = "finOca.png";

for (let i = 0; i < totalOcas; i++) {
    let random = Math.floor(Math.random() * tamañoTablero);
    do {
        random = Math.floor(Math.random() * tamañoTablero);
    } while (typeof tablero[random] !== 'undefined');
    tablero[random] = "oca.png";
}

for (let i = 0; i < totalPozos; i++) {
    let random = Math.floor(Math.random() * tamañoTablero);
    do {
        random = Math.floor(Math.random() * tamañoTablero);
    } while (typeof tablero[random] !== 'undefined');
    tablero[random] = "pozo.gif";
}

let tabla = "<table id='tablero'><tr><td id='salida'></td>";

for (let i = 0; i < tamañoTablero; i++) {
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


    let inicioPartida = false;
    let turno = 'fichaAzul';

    function jugarTurno() {
        let dado = Math.floor(Math.random() * 6) + 1;
        let casilla = parseInt($("#" + turno).attr('casilla')) + dado;
        casilla = casilla > 12 ? 12 : casilla;
        $("#" + turno).css({"-webkit-transform": "translate(" + (casilla * 63 + 10) + "px,0)"}).css('transition', 'all 2s');
        setTimeout(()=>{switch (tablero[casilla - 1]) {
            case 'pozo.gif':
                console.log("pozo");
                $("#" + turno).attr('casilla', 0);
                casilla = 0;
                $("#" + turno).css({"-webkit-transform": "translate(" + (casilla * 63 + 10) + "px,0)"}).css('transition', 'all 2s');
                cambiarTurno();
                break;
            case 'oca.png':
                let oca = tablero.indexOf('oca.png', casilla)+1;
                $("#" + turno).css({"-webkit-transform": "translate(" + (oca * 63 + 10) + "px,0)"}).css('transition', 'all 2s');
                $("#" + turno).attr('casilla', oca);
                break;

            default:
                $("#"+turno).attr('casilla',casilla);
                cambiarTurno();
                break;
        }
        }, 2500);


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
        } else {
            $(this).attr("disabled", true);
            jugarTurno();
            setTimeout(()=>{$(this).removeAttr("disabled")},5000);
        }

    });


});
