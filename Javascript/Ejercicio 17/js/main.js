"use strict";

let personas = [
    ['Pepe', 27, '612346545'],
    ['Maria', 20, '668784249'],
    ['Juan', 18, '655255658'],
    ['Lola', 42, '636494528']
];

console.log(personas);
console.log(personas[0]['nombre']);

let article = document.getElementsByTagName('article')[0];
let tabla = document.createElement('table');
let tbody = document.createElement('tbody');

personas.forEach((persona) => {
    var tr = document.createElement('tr');
    for (var i = 0; i < persona.length; i++) {
        var td = document.createElement('td');
        td.appendChild(document.createTextNode(persona[i]));
        tr.appendChild(td);
    }
    tbody.appendChild(tr);
});

let thead = document.createElement('thead');
let tr = document.createElement('tr');
let th = document.createElement('th');
th.appendChild(document.createTextNode('NOMBRE'));
tr.appendChild(th);
th = document.createElement('th');
th.appendChild(document.createTextNode('EDAD'));
tr.appendChild(th);
th = document.createElement('th');
th.appendChild(document.createTextNode('TELEFONO'));
tr.appendChild(th);
thead.appendChild(tr);
tabla.appendChild(thead);
tabla.appendChild(tbody);
article.appendChild(tabla);

