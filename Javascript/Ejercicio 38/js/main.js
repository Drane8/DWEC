"use strict";

let nombre = ""
    , telefono = "",
    ciudad = "";

$(document).ready(function () {
    $("#tel").focus()
        .blur(function () {
            telefono = $(this).val();
            $(this).css("text-transform", "capitalize");
        });
    $("#nom").blur(function () {
        nombre = $(this).val();
        $(this).css("text-transform", "capitalize");
    });
    $("#ciu").blur(function () {
        ciudad = $(this).val();
        $(this).css("text-transform", "capitalize");
    });
});


let anadidos = false;
let maxPalabras = 12;
let totalPalabras;
$("#term").click(function (ev) {
    ev.preventDefault();
    if (telefono === "" || nombre === "" || ciudad === "") {
        alert("Rellene todos los campos");
    } else {
        if (!anadidos) {
            $("input[type=text]").css("text-transform", "uppercase").attr("disabled", "disabled");
            $(".contenedor").append("\n" +
                "        <div id=\"dinamicos\">\n" +
                "            <label for=\"usu\">Usuario:</label><input type=\"text\" id=\"usu\"/><br/>\n" +
                "            <label for=\"pass\">Contraseña:</label><input type=\"password\" id=\"pass\"/><br/>\n" +
                "            <label for=\"passR\">Repetir contraseña:</label><input type=\"password\" id=\"passR\"/><br/>\n" +
                "        </div>");

            anadidos = true;
        }
    }
})
    .dblclick(function (ev) {
        ev.preventDefault();
        if (anadidos) {
            let usu = $("#usu").val();
            let pass = $("#pass").val();
            let passR = $("#passR").val();

            if (usu === "" || pass === "" || passR === "") {
                alert("Rellene todos los campos");
            } else if (usu === pass) {
                alert("El usuario y la contraseña no pueden coincidir");
            } else if (pass !== passR) {
                alert("Las contraseñas no coinciden")
            } else {
                $("input[type=text]").attr("disabled", "disabled");
                $(".contenedor").append("<label for=\"comentarios\" id='comen'>Comentarios:</label><textarea id=\"comentarios\" rows=\"4\" cols=\"50\">");
                $("form").append("\n" +
                    "        <br/><button id=\"env\">Enviar</button>\n" +
                    "        <button id=\"res\">Borrar</button>");
                $("#comentarios").keydown(function (ev) {
                    totalPalabras = $(this).val().split(/[\s]+/).length;
                    if (totalPalabras > maxPalabras) {
                        if (ev.keyCode == 48 || ev.keyCode == 8) {
                        } else if (ev.keyCode < 48 || ev.keyCode > 57) {
                            ev.preventDefault();
                        }
                    }
                });
                $("#env").click(function (ev) {
                    ev.preventDefault();
                    $("form").submit();
                });
                $("#res").click(function (ev) {
                    ev.preventDefault();
                    $("#dinamicos").remove();
                    $("#comentarios").remove();
                    $("#comen").remove();
                    $("#env").remove();
                    anadidos = false;
                    $("input[type=text]").css("text-transform", "none").removeAttr("disabled").val("");
                    $(this).remove();
                });
            }
        }
    });
