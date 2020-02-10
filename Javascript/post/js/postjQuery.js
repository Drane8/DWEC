"use strict";

window.addEventListener("load", function () {
    const boton = $("#enviar");
    const formato = $("#formulario");

    boton.on("click",function (ev) {
       ev.preventDefault();
       const formularioValores = formato.serialize();
       console.log(formularioValores);

       let req =$.ajax({
           type:"POST",
           url:"prueba.php",
           data:JSON.stringify(formularioValores),
           success:correctoPost
       });

       function correctoPost() {
           console.log("Todo bien");
       }

       req.done(function (response,textStatus,jqXHR) {
           console.log(3,"Todo bien",response,textStatus,jqXHR);
       });

        req.fail(function (jqXHR,textStatus,error) {
            console.log(4,textStatus);
        });

        req.always(function () {
            console.log("FIN");
        });

    });
});