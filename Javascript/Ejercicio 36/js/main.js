"use strict";

let texto = "Mostrar tablas";
let tablas = true;
document.getElementById("tablas").addEventListener("click", () => {
    $("#tablas").html(texto);
    if (tablas) {
        texto = "Ocultar tablas";
        tablas = false;
        $("table").addClass("hidden");
    } else {
        texto = "Mostrar tablas";
        tablas = true;
        $("table").removeClass("hidden");
    }
});

$("#mostrar").click(function () {
    let opcion = $('input[name=pais]:checked').val();
    switch (opcion) {
        case "eu":
            $("#europa").removeClass("hidden");
            break;
        case "as":
            $("#asia").removeClass("hidden");
            break;
        case "all":
            $("table").removeClass("hidden");
            break;
        default:
            alert("Seleccione una opcion");
            break;
    }
});

$("td").dblclick(function () {
    let numero ="";
    do {
        numero = prompt("Nueva medicion:");
    } while (isNaN(numero) || numero === "");

    $(this).html(numero);
});
