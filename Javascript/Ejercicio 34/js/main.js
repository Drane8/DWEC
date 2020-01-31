"use strict";
let select = "<select>";
for (let i = 0; i < 8; i++) {
    select += "<option value='" + (i + 1) + "'";
    if (i == 4) {
        select += "selected>(Por defecto) OPCION " + (i + 1) + "</option>";
    } else {
        select += ">OPCION " + (i + 1) + "</option>";
    }
}
select += "</select>";

$("#form").append(select);
$("select").children().filter(":selected").css("background-color", "red");
