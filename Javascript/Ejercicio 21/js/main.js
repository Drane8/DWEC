"use strict";

let totalAcumulado = {
    "enero": 0,
    "febrero": 0,
    "marzo": 0,
    "abril": 0,
    "mayo": 0,
    "junio": 0,
    "julio": 0,
    "agosto": 0,
    "septiembre": 0,
    "octubre": 0,
    "noviembre": 0,
    "diciembre": 0,
};

let cant = document.getElementById("cant");
cant.addEventListener("click", () => {
    let meses = document.getElementsByName("mes");
    let mesSeleccionado = "";
    document.getElementById("resul").innerHTML = "";
    meses.forEach((mes) => {
        if (mes.checked) {
            mesSeleccionado = mes.value;
            mes.checked = false;
        }
    });
    if (mesSeleccionado === "") {
        alert("Seleccione un mes");
    } else {
        meses.checked = false;
        do {
            var cantidad = prompt("Introduzca una cantidad");
        } while (isNaN(parseInt(cantidad)) || cantidad === null || parseInt(cantidad) < 0);
        if (cantidad === "00") {
            let resul="       MES      TOTAL ACUMULADO\n===================================";
            let total=0;
            for(let mes in totalAcumulado){
                resul+="\n " + String("          " + mes.toUpperCase()).slice(-10) +"          " + totalAcumulado[mes];
                total += totalAcumulado[mes];
            }
            resul+= "\n===================================\n TOTAL:              " +total;
            document.getElementById("resul").innerHTML = resul;
        } else {
            totalAcumulado[mesSeleccionado] += parseInt(cantidad);
        }
    }
});

