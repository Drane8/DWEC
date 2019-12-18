"use strict";

class Jugador {
    constructor(nombre) {
        this.nombre = nombre;
        this.hp = 100;
        this.sp = 100;
    };

    getNombre() {
        return this.nombre;
    }

    getSp() {
        return this.sp;
    }

    getHp() {
        return this.hp;
    }

    setNombre(nombre) {
        this.nombre = nombre;
    }

    setSp(sp) {
        this.sp = sp;
    }

    setHp(hp) {
        if (hp > 100) {
            this.hp = 100;
        } else if (hp < 0) {
            this.hp = 0;
        } else {
            this.hp = hp;
        }
    }

    curar(jugador) {
        if (!(jugador instanceof Jugador)) {
            alert("Error, no es un jugador");
        } else {
            if (this.sp < 40) {
                return false;
            } else {
                this.setSp(this.getSp() - 25);
                jugador.setHp(jugador.getHp() + 20);
                return true;
            }
        }
    }

    tirarFlecha(jugador) {
        if (!(jugador instanceof Jugador)) {
            alert("Error, jugadore erroneo");
        } else {
            jugador.setHp(jugador.getHp() - 20);
        }
    }

    pegarEspada(jugador) {
        if (!(jugador instanceof Jugador)) {
            alert("Error, jugadore erroneo");
        } else {
            let dmg = Math.floor(Math.random() * (40 - 15 + 1)) + 15;
            jugador.setHp(jugador.getHp() - dmg);
        }
    }

    mostrarDatos() {
        return "Jugador: " + this.getNombre() + "\nHP: " + this.getHp() + "\tSP: " + this.getSp();
    }
}

let numJugadores = 0;
do {
    numJugadores = prompt("Introduzca número de jugadores", 2);
} while (numJugadores <= 1);

let jugadores = [];

for (let i = 0; i < numJugadores; i++) {
    let nombre = "";
    do {
        nombre = prompt("Introduzca nombre del jugador " + (i + 1), "Jugador " + (i + 1));
    } while (nombre === "");
    jugadores.push(new Jugador(nombre));
}

let listaJugadores = "Lista jugadores:\n";
let contador = 0;
jugadores.forEach(jugador => {
    contador++;
    listaJugadores += jugador.getNombre() + "\t";
    if (contador % 5 === 0) {
        listaJugadores += "\n";
    }
});
document.getElementById("jugadores").innerHTML = listaJugadores;

let boton = document.getElementById("partida");
let ronda = 1;
boton.addEventListener("click", () => {
    if (numJugadores === 1) {
        document.getElementById("resul").innerHTML = "El ganador es " + jugadores[0].getNombre();
    } else {
        let resul = "Ronda " + ronda + "\n\n";
        ronda++;
        boton.innerHTML = "Jugar Ronda " + ronda;
        let muertos = "";
        for (let i = 0; i < numJugadores; i++) {
            let jugador = jugadores[i];
            if (jugador.getHp() > 0) {
                let accion = Math.floor(Math.random() * (3));
                let objetivo = Math.floor(Math.random() * (numJugadores));
                do {
                    objetivo = Math.floor(Math.random() * (numJugadores));
                } while (objetivo === i);
                let jugadorObjetivo = jugadores[objetivo];
                switch (accion) {
                    case 0:
                        if (jugador.curar(jugadorObjetivo)) {
                            resul += "\nEl jugador " + jugador.getNombre() + " ha curado a " +
                                jugadorObjetivo.getNombre();
                        } else {
                            resul += "\nEl jugador " + jugador.getNombre() + " ha  intentado curar a " +
                                jugadorObjetivo.getNombre() + " pero no ha podido";
                        }
                        break;
                    case 1:
                        jugador.tirarFlecha(jugadorObjetivo);
                        resul += "\nEl jugador " + jugador.getNombre() + " pega con arco a " +
                            jugadorObjetivo.getNombre();
                        break;
                    case 2:
                        jugador.pegarEspada(jugadorObjetivo);
                        resul += "\nEl jugador " + jugador.getNombre() + " pega un espadazo a " +
                            jugadorObjetivo.getNombre();
                        break;
                }
                resul += "\n\n---------------------------------------------------------\n" +
                    jugador.mostrarDatos() + "\n" + jugadorObjetivo.mostrarDatos() +
                    "\n---------------------------------------------------------\n";
            }
        }
        for (let i = 0; i < numJugadores; i++) {
            if (jugadores[i].getHp() === 0) {
                resul += "\nEl jugador " + jugadores[i].getNombre() + " ha muerto esta ronda";
                jugadores.splice(i, 1);
                numJugadores--;
            }
        }
        document.getElementById("resul").innerHTML = resul;
    }
});