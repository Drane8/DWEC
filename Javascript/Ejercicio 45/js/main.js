"use strict";


window.addEventListener("load", () => {
    $("#ejecutar").click(function(ev){
        ev.preventDefault();
        $("span.minoticia").css("background","red");
        $("p.minoticia").css("background","red");
    });
});
