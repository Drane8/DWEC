"use strict";

window.addEventListener("load", function () {
    let rutas = {
        _rutas: {},

        add(url, funcion) {
            this._rutas[url] = funcion;
        },

        run() {
            let url = location.href.split("/");
            url = url[url.length - 1];
            if (typeof rutas._rutas[url.toString()] !== 'undefined') {
                this._rutas[url.toString()]();
            }
        }
    };


    rutas.add("index.html", index);
    rutas.add("pepe.html", pepe);

    function index() {
        alert("Estás en el index.html")
    }

    function pepe() {
        alert("Estás en el pepe.html")
    }

    rutas.run();
});
