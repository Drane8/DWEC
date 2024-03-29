/*Daniel Garcia*/
"use strict";

function js1() {
    let num1, num2;

    do {
        num1 = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num1) || num1 <= 0);
    do {
        num2 = parseInt(prompt("Dame otro número", "1"));
    } while (isNaN(num2) || num2 <= 0);

    if (num1 === num2) {
        document.getElementById("resul").innerHTML = "Los numeros " + num1 +
            " y " + num2 + " son iguales";
    } else if (num1 > num2) {
        document.getElementById("resul").innerHTML = "El " + num1 + " es mayor que " + num2;
    } else {
        document.getElementById("resul").innerHTML = "El " + num1 + " es menor que " + num2;
    }
}

function js2() {

    let num, suma = 0, contador = 0;

    num = parseInt(prompt("Introduzca un número", "1"));
    while (num >= 0) {
        if (!isNaN(num)) {
            suma += num;
            contador++;
        }
        num = parseInt(prompt("Introduzca un número", "1"));
    }

    document.getElementById("resul").innerHTML = "Suma = " + suma + "\nMedia = " + (suma / contador);
}

function js3() {
    let num1, num2;

    do {
        num1 = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num1));

    do {
        num2 = parseInt(prompt("Dame otro número", "1"));
    } while (isNaN(num2) || num2 <= num1);

    let resul = "";

    for (let i = num1; i <= num2; i++) {
        if (i % 2 !== 0) {
            resul += " " + i;
        }
    }

    document.getElementById("resul").innerHTML = "Numeros impares:" + resul;
}

function js4() {
    let num;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0);

    let resul = "";

    for (let i = 2; i < num; i++) {
        if (num % i === 0) {
            resul += " " + i;
        }
    }

    document.getElementById("resul").innerHTML = "Numeros divisores:" + resul;

}

function js5() {
    let num;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0);

    let resul = "impar";

    if (num % 2 === 0) {
        resul = "par";
    }

    document.getElementById("resul").innerHTML = "El numero " + num + " es " + resul;
}

function js6() {
    let num, resul;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0);

    resul = "Tabla de multiplicar de " + num + "\n";

    for (let i = 1; i <= 10; i++) {
        resul += num + " * " + i + " = " + (num * i) + "\n";
    }

    document.getElementById("resul").innerHTML = resul;
}

function js7() {
    let num1, num2;

    do {
        num1 = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num1) || num1 <= 0);
    do {
        num2 = parseInt(prompt("Dame otro número", "1"));
    } while (isNaN(num2) || num2 <= 0);

    let resul = num1 + " + " + num2 + " = " + (num1 + num2) + "\n" +
        num1 + " - " + num2 + " = " + (num1 - num2) + "\n" +
        num1 + " * " + num2 + " = " + (num1 * num2) + "\n" +
        num1 + " / " + num2 + " = " + (num1 / num2) + "\n";

    console.log(resul);
    alert(resul);
    document.getElementById("resul").innerHTML = resul;

}

function js8() {
    let dni;
    let letras = ['T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'];

    dni = prompt("Introduzca su dni", "0");
    while (dni != null && (isNaN(parseInt(dni)) || dni < 0 || dni > 99999999)) {
        alert("Dni incorrecto");
        dni = prompt("Introduzca su dni", "1");
    }

    if (dni != null) {
        document.getElementById("resul").innerHTML = "letra del dni " + dni + " = " + letras[(dni % 23)];
    }
}

function js10() {
    let resul = "";
    for (let i = 1; i <= 30; i++) {
        for (let j = 1; j <= i; j++) {
            resul += i;
        }
        resul += "\n";
    }
    document.getElementById("resul").innerHTML = resul;
}

function js11() {

    let num;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0);

    let resul = "";
    for (let i = num; i >= 1; i--) {
        for (let j = 1; j <= i; j++) {
            resul += i;
        }
        resul += "\n";
    }
    document.getElementById("resul").innerHTML = resul;
}

function js12() {
    let resul = "";
    for (let i = 1; i <= 500; i++) {
        resul += i;
        if (i % 4 === 0) {
            resul += " (Múltiplo de 4)";
        }
        if (i % 9 === 0) {
            resul += " (Múltiplo de 9)";
        }
        resul += "\n";
        if (i % 5 === 0) {
            resul += "--------------------\n";
        }
    }

    document.getElementById("resul").innerHTML = resul;
}

function js13() {
    let filas, columnas;

    do {
        filas = parseInt(prompt("Introduzca nº filas", "1"));
    } while (isNaN(filas) || filas <= 0);
    do {
        columnas = parseInt(prompt("Introduzca nº columnas", "1"));
    } while (isNaN(columnas) || columnas <= 0);

    let resul = "<table>";

    for (let i = filas; i >= 1; i--) {
        resul += "<tr>";
        for (let j = columnas; j >= 1; j--) {
            resul += "<td>" + (j * i) + "</td>";
        }

        resul += "</tr>"
    }

    resul += "</table>";
    document.getElementById("resul").innerHTML = resul;
}

function js14() {
    let num1, num2, num3;
    num1 = Math.floor(Math.random() * 99) + 1;
    do {
        num2 = Math.floor(Math.random() * 99) + 1;
    } while (num2 === num1);
    do {
        num3 = Math.floor(Math.random() * 99) + 1;
    } while (num3 === num1 || num3 === num2);

    document.getElementById("resul").innerHTML = "Número aleatorio 1: " + num1 +
        "\nNúmero aleatorio 2: " + num2 + "\nNúmero aleatorio 3: " + num3;

}

function js15() {
    let texto;
    texto = prompt("Introduzca un texto:");
    let resul = texto.charAt(0);
    for (let i = 1; i < texto.length; i++) {
        resul += "-" + texto.charAt(i);
    }
    document.getElementById("resul").innerHTML = resul;
}

function js16() {
    let texto;
    texto = prompt("Introduzca un texto:");
    let vocales = texto.match(/[aeiou]/gi);
    let total = 0;
    if (vocales !== null) {
        total = vocales.length;
    }
    document.getElementById("resul").innerHTML = "Total vocales del texto:\n" + texto + "\nVocales: " + total;
}

function js17() {
    let texto;
    texto = prompt("Introduzca un texto:");
    let resul = "";
    let inicio = texto.indexOf("("), final = texto.lastIndexOf(")");
    if (inicio >= 0) {
        if (final === -1) {
            resul = texto.substr(inicio);
        } else {
            resul = texto.substring(inicio, final + 1);
        }
    }
    document.getElementById("resul").innerHTML = "Contenido entre parentesis: " + resul;
}

function js18() {
    let texto;
    texto = prompt("Introduzca un texto:");
    let resul = "";
    for (let i = texto.length - 1; i >= 0; i--) {
        resul += texto.charAt(i);
    }
    document.getElementById("resul").innerHTML = resul;
}

function js19() {
    let texto;
    texto = prompt("Introduzca un texto:");
    let resul = texto;
    texto = texto.toLowerCase().replace(/\s/g, "");
    let textoReves = "";
    for (let i = texto.length - 1; i >= 0; i--) {
        textoReves += texto.charAt(i);
    }
    if (texto === textoReves) {
        resul += "\nEs un palindromo";
    } else {
        resul += "\nNo es un palindromo"
    }
    document.getElementById("resul").innerHTML = resul;
}

function js20() {
    let num;
    do {
        num = parseInt(prompt("Introduzca un numero entre el 1 y el 100"));
    } while (isNaN(num) || num < 1 || num > 100);

    let a = 0, b = 1, temp;
    let resul = a + " ";
    for (let i = 0; i < (num - 1); i++) {
        temp = a + b;
        b = a;
        a = temp;
        resul += temp + " ";
        if (i % 5 === 0 && i !== 0) {
            resul += "\n";
        }
    }
    document.getElementById("resul").innerHTML = resul;
}

function js21() {
    let opciones = ['piedra', 'papel', 'tijera'];
    let pc = Math.floor(Math.random() * 3);
    let texto, resul;
    do {
        texto = prompt("Introduzca piedra, papel o tijera").toLowerCase().trim();
    } while (opciones.indexOf(texto) < 0);
    let jugador = opciones.indexOf(texto);

    if (pc === jugador) {
        resul = "Ambos elegisteis " + opciones[pc] + " por lo que es un empate."
    } else if (pc === 0) {
        if (jugador === 2) {
            resul = "Jugador: " + opciones[jugador] + "\nPC: " + opciones[pc] + "\nGana el PC";
        } else {
            resul = "Jugador: " + opciones[jugador] + "\nPC: " + opciones[pc] + "\nGana el Jugador";
        }
    } else if (pc === 1) {
        if (jugador === 0) {
            resul = "Jugador: " + opciones[jugador] + "\nPC: " + opciones[pc] + "\nGana el PC";
        } else {
            resul = "Jugador: " + opciones[jugador] + "\nPC: " + opciones[pc] + "\nGana el Jugador";
        }
    } else if (pc === 2) {
        if (jugador === 1) {
            resul = "Jugador: " + opciones[jugador] + "\nPC: " + opciones[pc] + "\nGana el PC";
        } else {
            resul = "Jugador: " + opciones[jugador] + "\nPC: " + opciones[pc] + "\nGana el Jugador";
        }
    }
    document.getElementById("resul").innerHTML = resul;
}

function asignarFunciones() {
    document.getElementById('ej1').addEventListener('click', function () {
        js1();
    }, false);
    document.getElementById('ej2').addEventListener('click', function () {
        js2();
    }, false);
    document.getElementById('ej3').addEventListener('click', function () {
        js3();
    }, false);
    document.getElementById('ej4').addEventListener('click', function () {
        js4();
    }, false);
    document.getElementById('ej5').addEventListener('click', function () {
        js5();
    }, false);
    document.getElementById('ej6').addEventListener('click', function () {
        js6();
    }, false);
    document.getElementById('ej7').addEventListener('click', function () {
        js7();
    }, false);
    document.getElementById('ej8').addEventListener('click', function () {
        js8();
    }, false);
    document.getElementById('ej10').addEventListener('click', function () {
        js10();
    }, false);
    document.getElementById('ej11').addEventListener('click', function () {
        js11();
    }, false);
    document.getElementById('ej12').addEventListener('click', function () {
        js12();
    }, false);
    document.getElementById('ej13').addEventListener('click', function () {
        js13();
    }, false);
    document.getElementById('ej14').addEventListener('click', function () {
        js14();
    }, false);
    document.getElementById('ej15').addEventListener('click', function () {
        js15();
    }, false);
    document.getElementById('ej16').addEventListener('click', function () {
        js16();
    }, false);
    document.getElementById('ej17').addEventListener('click', function () {
        js17();
    }, false);
    document.getElementById('ej18').addEventListener('click', function () {
        js18();
    }, false);
    document.getElementById('ej19').addEventListener('click', function () {
        js19();
    }, false);
    document.getElementById('ej20').addEventListener('click', function () {
        js20();
    }, false);
    document.getElementById('ej21').addEventListener('click', function () {
        js21();
    }, false);
}