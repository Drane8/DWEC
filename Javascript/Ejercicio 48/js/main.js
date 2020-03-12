"use strict";

let xilofono = ['blue', 'green', 'orange', 'yellow', 'brown', 'purple', 'red'];
let teclado = ['black', 'white', 'black', 'white', 'black', 'white', 'black'];
let tamano = 100;

function colorear(colores) {
    for (let i = 0; i < 7; i++) {
        let tecla = $("#teclado").find("div").eq(i);
        tecla.css("background-color", colores[i]).css("max-height","150px");
        colores[i] === 'black' ?
            tecla.css("color", 'white') : tecla.css("color", 'black')
    }
}

function tama() {
    for (let i = 0; i < 7; i++) {
        let tecla = $("#teclado").find("div").eq(i);
        tecla.css("height", tamano + "px").css("max-height",(tamano+50)+"px");
        guitarra ? tamano += 25 : tamano;
    }
    tamano = 100;
}

let piano = false;
let guitarra = false;
let tamaAnterior = '100px';
let notasTotales = 0;
let maxNotas = 10;

$(document).ready(function () {
    for (let i = 0; i < 7; i++) {
        let tecla = $("#notas").find("option").eq(i + 1);
        tecla.css("background-color", xilofono[i]);
    }
    colorear(xilofono);
    $("#pentagrama").css("background", "url('img/pentagrama.jpg')")
    $("#piano").click(function (ev) {
        ev.preventDefault();
        piano ? colorear(xilofono) : colorear(teclado);
        piano = !piano;
    });

    $("#plegar").click(function (ev) {
        ev.preventDefault();
        $("#teclado").slideToggle();

        $(this).text() === "Plegar" ? $(this).text("Desplegar") : $(this).text("Plegar");

    });

    $("#quitar").click(function (ev) {
        ev.preventDefault();

        let nota = $("#notas").val();
        if (nota !== 'null') {
            $("div#" + nota).toggle();
        }

    });

    $("#guitarra").click(function (ev) {
        ev.preventDefault();
        guitarra = !guitarra;
        tama();
    });

    $("#teclado div").hover(function () {
        tamaAnterior = $(this).height();
        $(this).animate({
            height: tamaAnterior + 50 + 'px'
        }, 100);

        maxNotas = parseInt(($("#pentagrama").width() - 100) / 30);

        if (notasTotales >= maxNotas){
            $(".nota").remove();
            $(".do").remove();
            notasTotales=0;
        }

        switch ($(this).attr('id')) {
            case 'do':
                $("#pentagrama").append("<img class='do' src='img/do.png' style='left:60px; top: 85px;'>");
                break;
            case 're':
                $("#pentagrama").append("<img class='nota' src='img/nota.png' style='left:60px; top: 78px;'>");
                break;
            case 'mi':
                $("#pentagrama").append("<img class='nota' src='img/nota.png' style='left:60px; top: 71px;'>");
                break;
            case 'fa':
                $("#pentagrama").append("<img class='nota' src='img/nota.png' style='left:60px; top: 63px;'>");
                break;
            case 'sol':
                $("#pentagrama").append("<img class='nota' src='img/nota.png' style='left:60px; top: 53px;'>");
                break;
            case 'la':
                $("#pentagrama").append("<img class='nota' src='img/nota.png' style='left:60px; top: 44px;'>");
                break;
            case 'si':
                $("#pentagrama").append("<img class='nota' src='img/nota.png' style='left:60px; top: 36px;'>");
                break;
        }
        notasTotales++;

    }, function () {

        $(this).animate({
            height: tamaAnterior + 'px'
        }, 100);

    })
});
