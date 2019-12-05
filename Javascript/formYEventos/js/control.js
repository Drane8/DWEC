"use strict";
//
// Cargo el fichero javascript, cuando se finaliza la carga del html
// con la opcion defer de la etiqueta script

// Podemos programar la carga del fichero con un evento,
// Usaremos el evento load, pero del objeto window
//window.addEventListener("load",()=>{

    // Detecto los distintos elementos que deben tener eventos y se los añado
    //primero el form : <form id="f1" name="ff1" class="formulario" action="#" onsubmit="return false"

    let aa=document.getElementById("f1");
    // asigno valores de atributo al formulario
    aa.name="ff1";
    aa.className="formulario";
    aa.action="#";

    aa.onsubmit = ()=>{return false};
    //aa.onsubmit = function (){return false};
    //aa.addEventListener("submit",()=>{return false});

    aa=document.getElementById("idDelInput");
    aa.placeholder="Ahora desde js";
    //aa.addEventListener("mouseleave",()=>{alert(a.value)});
    aa.addEventListener("mouseleave",()=>{
        let x=document.getElementById('idDelInput').value;
        alert(x);
    });
    aa=document.getElementById("apellido");
    aa.name="et1";
    aa.placeholder="Apellido de js";
    aa.value="Valor desde js";
    aa.addEventListener("mousewheel",()=>{
        let x=document.getElementById('apellido').value;
        alert(x);
    });

    // A los input radio, les añado el name de genero
    let b="";
    aa=document.querySelectorAll('[type="radio"]');
    aa.forEach((elemento)=>{elemento.name="genero"})

    aa=document.getElementById("sexo");

    // si usamos la propiedad on ... esta sobreescribe la anterior que
    // tengamos definica
    // el addeventllistener, no sobreescribe y ejecutará las funciones en orden

    //aa.onclick = ()=>{alert("uno")};
    //aa.onclick = ()=>{alert("dos")};
    //aa.addEventListener("click",()=>{alert("uno")});
    //aa.addEventListener("click",()=>{alert("dos")});

    aa.addEventListener("click",()=> {
        let sexo = document.getElementsByName("genero");
        sexo.forEach((a, b) => {
            // alert(sexo[b].checked);
            // alert(a.checked);
            if (a.checked) {
                document.getElementById("sexo1").innerHTML = a.value;
            }
            let salida = "";
            let vehi = document.querySelectorAll('input[name="vehiculo"]');
            //let vehi=document.querySelectorAll(".vehi");
            //let vehi=document.querySelectorAll('[name="vehiculo"]');
            //let vehi=document.getElementsByClassName("vehi");  ****** No recoge en array
            //let vehi=document.getElementsByName("vehiculo");

            vehi.forEach((a, b) => {
                if (a.checked) {
                    salida += a.value + "<br/>"
                }
            });
            document.getElementById("vehiculo").innerHTML = salida;
        });
    });

    aa=document.getElementById("bcolor");
    aa.addEventListener("click",()=>{fecha('color')});

    aa=document.getElementById("bfec");
    aa.addEventListener("click",()=>{let x=document.getElementById('fec').value; alert(x);});

    aa=document.getElementById("bfec1");
    aa.addEventListener("click",()=>{
        let a=document.getElementById('fec1').value;
        alert(a)
    });

    aa=document.getElementById("bnum");
    aa.addEventListener("click",()=>{fecha("num")});
//});


function fecha(ids) {
    let x = document.getElementById(ids).value;
    alert(x);
}