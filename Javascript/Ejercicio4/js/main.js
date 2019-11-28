"use strict";

let form = document.getElementById("form1");
form.name = "formulario";
form.action = "#";

let ope = "";

let sum = document.getElementById("sum");
sum.addEventListener("click", () => {
    calcular("+");
});

let res = document.getElementById("res");
res.addEventListener("click", () => {
    calcular("-");
});

let mul = document.getElementById("mul");
mul.addEventListener("click", () => {
    calcular("*");
});

let div = document.getElementById("div");
div.addEventListener("click", () => {
    calcular("/");
});

function calcular(ope) {
    let resul = "";
    let num1 = parseInt(document.getElementById("num1").value);
    let num2 = parseInt(document.getElementById("num2").value);
    if (num1 === "" || num2 === "") {
        alert("Introduzca ambos numeros");
    } else if (isNaN(num1) || isNaN(num2)) {
        alert("Introduzca valores correctos");
    } else if (ope === "") {
        alert("Seleccione un operador");
    } else {
        switch (ope) {
            case "+":
                resul = num1 + num2;
                break;
            case "-":
                resul = num1 - num2;
                break;
            case "*":
                resul = num1 * num2;
                break;
            case "/":
                resul = num1 / num2;
                break;
        }
        document.getElementById("resul").value = resul;
    }
}