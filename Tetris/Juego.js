var canvas;
var ctx; 
var fps = 50;

var anchoTablero = 10;
var altoTablero = 16;

var altoF = 40;
var AnchoF = 40;

var AnchoCanvas = 600;
var AltoCanvas = 640;

var tablero = [
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,0,0,0,0,0,0,0,0,0,0,1]
[1,0,0,0,0,0,0,0,0,0,0,1],
[1,1,1,1,1,1,1,1,1,1,1,1]];

var Pieza;
 
var objPieza = function(){
this.x =0;
this.y=0;

console.log("pieza");
}

function inicializarTeclado(){
    document.addEventListener('keydown', function(tecla){

    if (tecla.keyCode == 38){
        console.log("Arriba");
    }

    if (tecla.keyCode == 40){
        console.log("Abajo");
    }

    if (tecla.keyCode == 37){
        console.log("Izquierda");
    }

    if (tecla.keyCode == 39){
        console.log("Derecha");
    }

    });
}

function inicializar(){

    canvas = document.getElementById("canvas");
    ctx = canvas.getContext('2d');

    canvas.style.width = AnchoCanvas;
    canvas.style.height = AltoCanvas;

    Pieza = new objPieza();

    inicializarTeclado();

    setInterval(function(){
        principal();
    },1000/fps)
    
}

function borrarCanvas(){
    canvas.width = AnchoCanvas;
    canvas.height = AltoCanvas;
}

function principal(){
    borrarCanvas();
}