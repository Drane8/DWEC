"use strict";


let frutas = ["Naranjas", "Manzanas", "Cerezas", "Platanos", "Patatas", "Peras", "Fresas"];
let provincias = ["Jaen", "Cordoba", "Sevilla", "Huelva", "Cadiz"];

for (let i = 0; i < frutas.length; i++) {
    let opcion = "<option value='" + frutas[i] + "'>" + frutas[i] + "</option>";
    $("#frutas").append(opcion);
}

$("#cod").focus();

$("#cod").blur(function () {
    let codigo = $(this).val();
    let exp = /\b([1-5]\d{4})\b/g;
    if (!exp.test(codigo)) {
        alert("Código no válido");
        setTimeout(function () {
            $("#cod").focus();
        }, 50);
    } else {
        $("#prov").val(provincias[codigo.charAt(0) - 1]);
    }
});

$("#comprar").click(function () {
    let opciones = $("#frutas").val();
    let cantidad = $("#cant").val();
    if ($("#pass2").val() !== $("#pass1").val() || $("#pass2").val() === "") {
        alert("No coinciden las contraseñas");
    } else if (opciones.length === 0) {
        alert("No ha seleccionado ningun producto");
    } else if (isNaN(cantidad) || cantidad === "") {
        alert("Cantidad incorrecta");
    } else {
        let texto = $("#compras").val();
        for (let i = 0; i < opciones.length; i++) {
            texto += opciones[i] + " *** " + cantidad + "Kgrs." + "\n";
        }
        console.log(texto);
        $("#compras").val(texto);
    }

});

$("#reset").click(function () {
    $("input").val("");
    $("#compras").val("");
    $("#frutas").val("");
    $("#cod").focus();
});
