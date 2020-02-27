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
let formAbierto = false;
let empresitas = [];

function crearCheckbox(nombre) {
    $("#radios").append("<li id='li" + nombre + "'><label for='" + nombre + "'>" + nombre + "</label>" +
        "<input type='radio' name='radChe' id='" + nombre + "' value='" + nombre + "'/></li>");
    $("#" + nombre).checkboxradio();
}

$(document).ready(function () {
    $("#radios").sortable();

    $("#menu").sortable();

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
            if(empresitas.includes(radioValue)){
                empresitas.splice(empresitas.indexOf(radioValue))
            }
        }
    });

    $("#visualizar").click(function () {
        let radioValue = $("input[name='radChe']:checked").val();
        if (radioValue === "" || radioValue == undefined) {
            alert("Seleccione un radio");
        } else {
            $("#dialog" + radioValue).dialog("open");
        }
    });

    $("#datos").click(function () {
        if (!datosInsertados) {
            if (!formAbierto) {
                formAbierto = true;
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
                        formAbierto = false;
                        $("#f_datos").remove();
                    }

                });
            }
        } else {
            alert("Ya hay datos insertados");
        }
    });

    $("#empresa").click(function () {
        if (empresitas.length >= 3) {
            alert("Se ha alcanzado el máximo de empresas (3)")
        } else {
            if (!formAbierto) {
                formAbierto = true;
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
                            formAbierto = false;
                            $("#f_emp").remove();
                        }
                    }
                );

            }
        }
    });

    $("#empresa").click(function () {
        if (empresitas.length >= 3) {
            alert("Se ha alcanzado el máximo de empresas (3)")
        } else {
            if (!formAbierto) {
                formAbierto = true;
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
                            $("body").append("<div id=\"dialog" + nomEm + "\" title=\"Empresa\">\n" +
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
                            formAbierto = false;
                            $("#f_emp").remove();
                        }
                    }
                );

            }
        }
    });

    $("#organizacion").click(function () {
        if (empresitas.length < 1) {
            alert("No hay empresas introducidas")
        } else {
            if (!formAbierto) {
                formAbierto = true;

                let formulario = "<form id='f_org'>\n" +
                    "                <label for=\"nomOrg\">Nombre</label><input type=\"text\" id=\"nomOrg\"/><br/>\n" +
                    "                <label for=\"pais\">País</label><input type=\"text\" id=\"pais\"/><br/>\n" +
                    "<select id='empresas' multiple>";
                    for(let empresita of empresitas){
                        formulario += "<option value='" + empresita + "'>" + empresita + "</option>";
                    }


                     formulario +=" </select><button id=\"terminarOrg\">Terminar</button>\n" +  "</form>";

                $("#form").append(formulario);
                $("#terminarOrg").click(function (ev) {
                        ev.preventDefault();


                        let nomOrg = $("#nomOrg").val();
                        let pais = $("#pais").val();
                        let empresas = $("#empresas").val();
                        if (nomOrg === "" || pais === "" || empresas.length === 0) {
                            alert("Rellene todos los campos");
                        } else if (empresitas.includes(nomOrg)) {
                            alert("No puede tener el mismo nombre que una empresa");
                        }else {
                            crearCheckbox(nomOrg);
                            let dialog = "<div id=\"dialog" + nomOrg + "\" title=\"Organizacion\">\n" +
                                "Nombre: " + nomOrg + "<br/>Pais: " + pais + "<br/>Empresas: " + empresas + "   \n" +
                                "</div>";
                            $("body").append(dialog);
                            $("#dialog" + nomOrg).dialog({
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
                            formAbierto = false;
                            $("#f_org").remove();
                        }
                    }
                );

            }
        }
    });

})
;


