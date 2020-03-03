"use strict";


window.addEventListener("load", () => {
    $("#foto_34").mousemove(function (ev) {
        let Offset = $(this).offset();
        let x = ev.pageX - Offset.left;
        let y = ev.pageY - Offset.top;
        $("#informacion").text("X=" + x + " Y=" + y);
    });
});
