//juego basico
var canvas;
var ctx;
var fps = 50;

var anchof = 50;
var altof = 50;

var cesped = '#0FCE52';
var agua = '#284FEC';
var tierra = '#752905';
var puerta = '#3a1700';
var llave = '#c6bc00';

var clorProta = '#820c01';

var escenario = [
   //1  2  3   4  5  6  7  8  9  10
    [2, 0, 0, 0, 0, 0, 0, 0, 0, 0], //1
    [2, 2, 0, 2, 2, 2, 2, 0, 2, 0], //2
    [0, 2, 2, 2, 1, 1, 2, 0, 2, 0], //3
    [0, 2, 0, 2, 2, 1, 2, 0, 2, 0], //4
    [0, 2, 0, 2, 1, 1, 2, 2, 2, 0], //5
    [0, 2, 0, 2, 1, 1, 1, 2, 1, 1], //6
    [0, 2, 0, 2, 0, 0, 1, 2, 0, 0], //7
    [0, 2, 2, 2, 2, 0, 1, 2, 2, 2], //8
    [0, 2, 1, 1, 2, 2, 1, 2, 3, 2], //9
    [0, 2, 2, 4, 1, 1, 1, 2, 2, 2] //10
];

function dibujarEscenario() {
    var color;
    for (y = 0; y < escenario.length; y++) {
        for (x = 0; x < escenario.length; x++) {
            if (escenario[y][x] == 0)
                color = cesped;

            if (escenario[y][x] == 1)
                color = agua;

            if (escenario[y][x] == 2)
                color = tierra;

            if (escenario[y][x] == 3)
                color = puerta;

            if (escenario[y][x] == 4)
                color = llave;

            ctx.fillStyle = color;
            ctx.fillRect(x * anchof, y * altof, anchof, altof);
        }
    }

}

var jugador = function() {
    this.x = 0;
    this.y = 0;
    this.color = '#820c01';
    this.llave = false;

    this.dibuja = function() {
        ctx.fillStyle = this.color;
        ctx.fillRect(this.x * anchof, this.y * altof, anchof, altof);

    }

    this.margenes = function(x, y) {
        var colicion = false;

        if (escenario[y][x] == 0 || escenario[y][x] == 1) {
            colicion = true;

        }
        return (colicion);
    }

    this.arriba = function() {
        if (this.margenes(this.x, this.y - 1) == false) {
            this.y--;
            this.logicaObjetos();
        }
    }

    this.abajo = function() {
        if (this.margenes(this.x, this.y + 1) == false) {
            this.y++;
            this.logicaObjetos();
        }
    }

    this.derecha = function() {
        if (this.margenes(this.x - 1, this.y) == false) {
            this.x--;
            this.logicaObjetos();
        }
    }

    this.izquierda = function() {
        if (this.margenes(this.x + 1, this.y) == false) {
            this.x++;
            this.logicaObjetos();
        }
    }

    this.victoria = function() {
        prompt("Has ganado");
        this.x = 0;
        this.y = 0;
        this.llave = false;
        escenario[9][3] = 4;

    }

    this.logicaObjetos = function() {
        var objeto = escenario[this.y][this.x];

        if (objeto == 4) {
            this.llave = true;
            escenario[this.y][this.x] = 1;
            console.log("nice");

        }

        if (objeto == 3) {
            if (this.llave == true) {
                this.victoria();
            } else { console.log("Debes tener una llave para pasar"); }
        }
    }



}



var protagonista;

function inicializa() {
    canvas = document.getElementById('canvas');
    ctx = canvas.getContext('2d');

    protagonista = new jugador;

    setInterval(function() {
        principal();
    }, 1000 / fps);
}

document.addEventListener('keydown', function(tecla) {
    if (tecla.keyCode == 38) {
        protagonista.arriba();
    }

    //abajo
    if (tecla.keyCode == 40) {
        protagonista.abajo();
    }

    //izquierda
    if (tecla.keyCode == 39) {
        protagonista.izquierda();
    }

    //derecha
    if (tecla.keyCode == 37) {
        protagonista.derecha();
    }


})


function principal() {
    borraCanvas();
    dibujarEscenario();
    console.log("FPS");
    protagonista.dibuja();
}

function borraCanvas() {
    canvas.width = 500;
    canvas.higth = 500;
}