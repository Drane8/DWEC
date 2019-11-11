function js1() {
    let num1, num2;

    do {
        num1 = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num1) || num1 <= 0)
    do {
        num2 = parseInt(prompt("Dame otro número", "1"));
    } while (isNaN(num2) || num2 <= 0)

    if (num1 == num2) {
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
    } while (isNaN(num1))

    do {
        num2 = parseInt(prompt("Dame otro número", "1"));
    } while (isNaN(num2) || num2 <= num1)

    let resul = "";

    for (let i = num1; i <= num2; i++) {
        if (i % 2 != 0) {
            resul += " " + i;
        }
    }

    document.getElementById("resul").innerHTML = "Numeros impares:" + resul;
}

function js4() {
    let num;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0)

    let resul = "";

    for (let i = 2; i < num; i++) {
        if (num % i == 0) {
            resul += " " + i;
        }
    }

    document.getElementById("resul").innerHTML = "Numeros divisores:" + resul;

}

function js5() {
    let num;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0)

    let resul = "impar";

    if (num % 2 == 0) {
        resul = "par";
    }

    document.getElementById("resul").innerHTML = "El numero " + num + " es " + resul;
}

function js6() {
    let num;

    do {
        num = parseInt(prompt("Dame un número", "1"));
    } while (isNaN(num) || num <= 0)

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
    } while (isNaN(num1) || num1 <= 0)
    do {
        num2 = parseInt(prompt("Dame otro número", "1"));
    } while (isNaN(num2) || num2 <= 0)

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

    dni = prompt("Introduzca su dni", "0")
    while (dni != null && (isNaN(parseInt(dni)) || dni < 0 || dni > 99999999)) {
        alert("Dni incorrecto");
        dni = prompt("Introduzca su dni", "1");
    }

    if (dni != null) {
        document.getElementById("resul").innerHTML = "Letra del dni " + dni + " = " + letras[(dni % 23)];
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
    } while (isNaN(num) || num <= 0)

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
        if (i % 4 == 0) {
            resul += " (Múltiplo de 4)";
        }
        if (i % 9 == 0) {
            resul += " (Múltiplo de 9)";
        }
        resul += "\n"
        if (i % 5 == 0) {
            resul += "--------------------\n";
        }
    }

    document.getElementById("resul").innerHTML = resul;
}

function js13() {
    let filas, columnas;

    do {
        filas = parseInt(prompt("Introduzca nº filas", "1"));
    } while (isNaN(filas) || filas <= 0)
    do {
        columnas = parseInt(prompt("Introduzca nº columnas", "1"));
    } while (isNaN(columnas) || columnas <= 0)

    let resul = "<table>";

    for (let i = filas; i >= 1; i--) {
        resul+="<tr>"
        for (let j = columnas; j >= 1; j--) {
            resul+="<td>" + (j*i) + "</td>";
        }

        resul+="</tr>"
    }

    resul += "</table>"
    document.getElementById("resul").innerHTML = resul;
}