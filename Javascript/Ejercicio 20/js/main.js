"use strict";

let alumnos = [
    ["Jaimito", 7, 9, 6],
    ["Pepito", 3, 5, 7],
    ["Juanita", 5, 9, 1],
    ["Laurita", 6, 6, 6]
];
let resul = "Alumnos: \n";
alumnos.forEach((alumno) => {
    resul += alumno + "\n";
});

document.getElementById("array").innerHTML = resul;
document.getElementById("dat").addEventListener("click", () => {
    let nombre = document.getElementById("nom").value;
    let alumno = null;
    if (nombre === "") {
        alert("Introduzca un nombre");
    } else {
        alumnos.forEach((alu) => {
            if (alu[0] === nombre) {
                alumno = alu;
            }
        });
        if (alumno === null) {
            alert("El alumno no existe")
        } else {
            resul = "Alumno : " + alumno[0] + "\nNotas:";
            let estado = "Aprobado";
            let media = 0;
            for (let i = 1; i < alumno.length; i++) {
                let nota = alumno[i];
                media += nota;
                if (nota < 5) {
                    estado = "Suspenso";
                }
                resul += " " + nota;
            }
            media /= (alumno.length-1);
            resul += "\nMedia: " + media.toFixed(2) + "\n" + estado;
            document.getElementById("resul").innerHTML = resul;
        }
    }
});

