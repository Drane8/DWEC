"use strict";
window.addEventListener("load", function () {

    const boton = document.querySelector("#enviar");
    const formato = document.querySelector("#formulario");

    boton.addEventListener("click", (evt => {
        evt.preventDefault();

        const formularioValores = new FormData(formato);

        for (let i of formularioValores) {
            console.log(1,i);
        }

        fetch("prueba.php",{
            method:"POST",
            body:formularioValores
        })
            .then(data=>{
                console.log(data);
                if(data.status!==0){

                }
            })
            .catch(razon=>console.log(razon))
            .then(()=>console.log("ya"));

    }));

});