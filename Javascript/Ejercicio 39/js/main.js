"use strict";

$(document).ready(function () {

    $("fieldset:nth-child(1)").show("slide", 500);
    setTimeout(function () {
        $("fieldset:nth-child(2)").show("slide", 500);
    }, 1000);
    setTimeout(function () {
        $("fieldset:nth-child(3)").show("fold", 1000);
    }, 2000);
    setTimeout(function () {
        $("fieldset:nth-child(4)").show("fold", 1000);
    }, 3500);
    setTimeout(function () {
        $("#botones").show();
    }, 4600);



    let dniRegex = /^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]$/i;
    let letras = 'TRWAGMYFPDXBNJZSQVHLCKET';

    $("#dni").blur(function () {
        let dni = $(this).val();
        if (!dniRegex.test(dni)) {
            alert("Formato del dni incorrecto");
            $(this).val("");
            dni = "";
        } else {
            let letraValida = letras[parseInt(dni.substr(0, 8)) % 23];
            if (dni.charAt(8).toUpperCase() !== letraValida) {
                alert("El dni es incorrecto");
                $(this).val("");
                dni = "";
            }
        }

    });

    $("#edad").bind('keyup blur', function () {
            $(this).val($(this).val().replace(/[^0-9]/g, ''));
        }
    ).blur(function () {
        let edad = $(this).val();
        if (edad < 1 || edad > 100) {
            alert("Introduzca una edad comprendida entre 1 y 100")
        }
    });

    $("#nombre").bind('keyup blur', function () {
            $(this).val($(this).val().replace(/[^A-Za-z ]/g, ''));
        }
    );
    $("#apellidos").bind('keyup blur', function () {
            $(this).val($(this).val().replace(/[^A-Za-z ]/g, ''));
        }
    );

    $("#env").click(function (ev) {
            ev.preventDefault();
            let nombre = $("#nombre").val();
            let apellidos = $("#apellidos").val();
            let dni = $("#dni").val();
            let edad = $("#edad").val();
            let sexo = $("#sexo").val();
            let MejPel = $("#MejPel").val();
            let peli = $("#peli").val();

            if (nombre === "") {
                alert("Introduzca el nombre");
            } else if (apellidos === "") {
                alert("Introduzca los apellidos");
            } else if (dni === "") {
                alert("Introduzca el dni");
            }else if (edad === "") {
                alert("Introduzca su edad");
            }else if (sexo === "") {
                alert("Seleccione el sexo");
            }else if (MejPel === "") {
                alert("Elija la mejor película");
            }else if (peli === "") {
                alert("Escoja su pelicula");
            }else {
                $("form").submit();
            }
        }
    );

    $("#bor").click(function (ev) {
        ev.preventDefault();
        $('form').trigger("reset");
    });
});


