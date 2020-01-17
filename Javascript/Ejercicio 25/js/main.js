"use strict";

localStorage.clear();
let email;
let telef;
let ip;
let fec;

document.getElementById("valEm").addEventListener("click", () => {
    email = document.getElementById("email").value.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
    if (email === null) {
        alert("No se ha encontrado ningun email");
    } else {
        document.getElementById("ema").innerHTML = email[0];
        document.getElementById("valEm").disabled = true;
        document.getElementById("valTel").disabled = false;
    }
});
document.getElementById("valTel").addEventListener("click", () => {
    telef = document.getElementById("telefono").value.match(/\(\d{3}\) \d{2} \d{2} \d{2}/g);
    if (telef === null) {
        alert("No se ha encontrado ningun telefono");
    } else {
        document.getElementById("tel").innerHTML = telef[0];
        document.getElementById("valTel").disabled = true;
        document.getElementById("valIp").disabled = false;
    }
});
document.getElementById("valIp").addEventListener("click", () => {
    ip = document.getElementById("ip").value.match(/\d{1,3},\d{1,3},\d{1,3}/g);
    if (ip === null) {
        alert("No se ha encontrado ninguna ip");
    } else {
        document.getElementById("dip").innerHTML = ip[0];
        document.getElementById("valIp").disabled = true;
        document.getElementById("valFec").disabled = false;
    }
});
document.getElementById("valFec").addEventListener("click", () => {
    fec = document.getElementById("fecha").value.match(/\d{1,2}\/\d{1,2}\/\d{2,4}/g);
    if (fec === null) {
        alert("No se ha encontrado ninguna fecha");
    } else {
        document.getElementById("fec").innerHTML = fec[0];
        document.getElementById("valFec").disabled = true;
        document.getElementById("mos").disabled = false;
    }
});

document.getElementById("mos").addEventListener("click", () => {
    document.getElementById("resul").innerHTML = "Email: " + email + "\n" +
        "Telefono: " + telef +"\n" +
        "Direccion IP: " + ip + "\n" +
        "Fecha de nacimiento: " +fec;

    document.getElementById("mos").disabled = true;
    document.getElementById("valEm").disabled = false;
});
