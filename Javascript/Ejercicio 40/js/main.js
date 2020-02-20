"use strict";

let formDatos = "<form id='f_datos'>\n" +
    "                <label for=\"user\">Usuario</label><input type=\"text\" id=\"user\"/><br/>\n" +
    "                <label for=\"pass\">Password</label><input type=\"password\" id=\"pass\"/><br/>\n" +
    "                <button id=\"terminar\">Terminar</button>\n" +
    "            </form>";

let formEmpresa = "<form id='f_emp'>\n" +
    "                <label for=\"nomEm\">Nombre</label><input type=\"text\" id=\"nomEm\"/><br/>\n" +
    "                <label for=\"dir\">Direccion</label><input type=\"text\" id=\"dir\"/><br/>\n" +
    "                <label for=\"local\">Localidad</label><input type=\"text\" id=\"local\"/><br/>\n" +
    "                <button id=\"terminarEm\">Terminar</button>\n" +
    "            </form>";

let datosInsertados = false;
let formEmpAbierto = false;
let empresitas = [];

function crearCheckbox(nombre) {
    $("#radios").append("<li id='li"+nombre+"'><label for='" + nombre + "'>" + nombre + "</label>" +
        "<input type='radio' name='radChe' id='" + nombre + "' value='" + nombre + "'/></li>");
    $("#" + nombre).checkboxradio();
}

$(document).ready(function () {
    $("#radios").sortable();

    $('#menu').menu();

    $('#menu').menu({
        position: {my: 'left top', at: 'left bottom'},
        blur: function () {
            $(this).menu('option', 'position', {my: 'left top', at: 'left bottom'});
        },
        focus: function (e, ui) {
            if ($('#menu').get(0) !== $(ui).get(0).item.parent().get(0)) {
                $(this).menu('option', 'position', {my: 'left top', at: 'right top'});
            }
        },
    });

    $("#borrar").click(function () {
        let radioValue = $("input[name='radChe']:checked").val();
        if (radioValue === "" || radioValue == undefined) {
            alert("Seleccione un radio");
        } else {
            $("#li" + radioValue).remove();
            $("#dialog" + radioValue).remove();
            if (radioValue === "Datos") {
                datosInsertados = false;
            }
        }
    });

    $("#visualizar").click(function () {
        let radioValue = $("input[name='radChe']:checked").val();
        $("#dialog" + radioValue).dialog("open");
    });

    $("#datos").click(function () {
        if (!datosInsertados) {
            $("#form").append(formDatos);
            $("#terminar").click(function (ev) {
                ev.preventDefault();
                let usuario = $("#user").val();
                let pass = $("#pass").val();
                if (usuario === "" || pass === "") {
                    alert("Rellene todos los campos")
                } else {
                    crearCheckbox("Datos");
                    datosInsertados = true;
                    $("body").append("<div id=\"dialogDatos\" title=\"Datos\">\n" +
                        "Nombre: " + usuario + "<br/>Pass: " + pass + "   \n" +
                        "</div>");
                    $("#dialogDatos").dialog({
                        autoOpen: false,
                        show: {
                            effect: "blind",
                            duration: 1000
                        },
                        hide: {
                            effect: "explode",
                            duration: 1000
                        }
                    });
                    $("#f_datos").remove();
                }

            });
        } else {
            alert("Ya hay datos insertados");
        }
    });

    $("#empresa").click(function () {
        if (!formEmpAbierto) {
            formEmpAbierto = true;
            $("#form").append(formEmpresa);
            $("#terminarEm").click(function (ev) {
                    ev.preventDefault();
                    let nomEm = $("#nomEm").val();
                    let dir = $("#dir").val();
                    let local = $("#local").val();
                    if (nomEm === "" || dir === "" || local === "") {
                        alert("Rellene todos los campos");
                    } else if (empresitas.includes(nomEm)) {
                        alert("La empresa ya existe");
                    } else {
                        crearCheckbox(nomEm);
                        $("body").append("<div id=\"dialog" + nomEm + "\" title=\"Datos\">\n" +
                            "Nombre: " + nomEm + "<br/>Direccion: " + dir + "   \n" + "<br/>Localidad: " + local + "   \n" +
                            "</div>");
                        $("#dialog" + nomEm).dialog({
                            autoOpen: false,
                            show: {
                                effect: "blind",
                                duration: 1000
                            },
                            hide: {
                                effect: "explode",
                                duration: 1000
                            }
                        });
                        empresitas.push(nomEm);
                        formEmpAbierto = false;
                        $("#f_emp").remove();
                    }
                }
            );

        }
    });

})
;


