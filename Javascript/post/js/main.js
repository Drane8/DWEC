"use strict";
window.addEventListener("load", function () {

    const boton = document.getElementById("enviar");
    const formato = document.getElementById("formulario");

    boton.addEventListener("click", (ev => {
        ev.preventDefault();

        const formularioValores = new FormData(formato);

        for (let i of formularioValores) {
            console.log(1,i);
        }

        const xhr = new XMLHttpRequest();
        xhr.open("POST","prueba.php",true);
        //xhr.setRequestHeader("Content-type","application/x-www-form-urlencode");
        xhr.send(formularioValores);
        if(xhr.status===200){
            console.log("Todo subido");
        }else{
            console.log("Error "+xhr.statusText);
        }

    }));

});
