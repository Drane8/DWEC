"use strict";

window.onload = () => {

    $(document).ready(function () {

        //Eventos blur y focus
        let nombre = $("#nombre").focus(function () {
            //$(this).css("border","4px solid black")
            nombre.css("border", "4px solid black");
            $("#datos")
                .show("slow")
                .fadeIn()
                .css("border-color","blue");
        });
        nombre.blur(function () {
            nombre.css("border","1px solid red")
            $("#datos")
                .show("slow")
                .fadeOut()
                .css("border-color","blue");
        });
        nombre.change(function () {
            $("#datos").text(nombre.val())
        })
    })

};