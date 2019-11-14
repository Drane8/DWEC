"use strict";

function sexo() {
    let sexo = document.getElementsByName('genero');

    sexo.forEach((a, b) => {
        if (a.checked) {
            document.getElementById("sexo").innerHTML = a.value;
        }
    })

    let salida=""

    let vehi=document.getElementsByName("vehiculo");
    //let vehi = document.querySelectorAll("input[name='vehiculo'])

    vehi.forEach(value =>{
        if (value.checked){
            salida +=value.value +"<br>";
        }
    })

    document.getElementById("vehiculo").innerHTML = salida;
}