function comprobarGanar(marcada, turno) {
    let combinaciones = [[1, 2, 3], [4, 5, 6], [7, 8, 9],
        [1, 4, 7], [2, 5, 8], [3, 6, 9],
        [1, 5, 9], [3, 5, 7]];

    let posCasilla = parseInt(marcada.id.split("-")[1]);

    console.clear();
    for (let combinacion of combinaciones) {
        if (combinacion.indexOf(posCasilla) >= 0) {
            let vecesRep = 0;
            for (let pos of combinacion) {
                let clasesCasilla = $("#casilla-" + pos).attr("class").split(" ");
                vecesRep = clasesCasilla.indexOf(turno) > 0 ? vecesRep + 1 : vecesRep;
            }
            if (vecesRep === 3) {
                $("#resul").append("<p>Ha ganado el jugador " + turno+"</p>");
                reset();
                marcarGanado(combinacion);
                return true;
            }
        }
    }

    if (casillasOcupadas === 9) {
        alert("Empate");
        return true;
    }

    turnoActual = turnoActual === 'x' ? 'o' : 'x';
    $("#turnox").toggleClass("active");
    $("#turnoo").toggleClass("active");
}

function reset() {
    $("#resul").append("<button id='reset'>Reiniciar partida</button>");
    $("#reset").click(function (ev) {
        ev.preventDefault();
        $(".casilla").removeClass("ocupada").removeClass("x").removeClass('o').css("background-color","transparent");
        fin = false;
        turno = "x";
        casillasOcupadas = 0;
        $("#turnox").removeClass("active").addClass("active");
        $("#turnoo").removeClass("active");
        $("#resul").empty();
    })
}

function marcarGanado(combinacion) {
    console.log("holi");
    for(let casilla of combinacion){
        $("#casilla-" + casilla).css("background-color","lightgrey")
    }
}

let fin = false;
let turnoActual = "x";
let casillasOcupadas = 0;

$(document).ready(function () {
    $(".container").append("\n" +
        "            <div class=\"casilla\" id=\"casilla-1\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-2\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-3\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-4\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-5\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-6\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-7\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-8\"></div>\n" +
        "            <div class=\"casilla\" id=\"casilla-9\"></div>\n");

    $("#turnox").toggleClass("active")

    $(".casilla").on('click', function () {
        if (!fin) {
            var clases = $(this).attr("class");
            if (clases.indexOf("ocupada") >= 0) {
                alert("Casilla ocupada");
            } else {
                $(this).addClass('ocupada').addClass(turnoActual);
                casillasOcupadas++;
                fin = comprobarGanar(this, turnoActual);
            }
        }
    });
});
