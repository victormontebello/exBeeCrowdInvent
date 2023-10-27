var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split(' ');

const a = Number(lines[0]);
const b = Number(lines[1]);
const c = Number(lines[2]);

const areatri = ((a*c)/(2.0)).toFixed(3);
const cir = (c*c*3.14159).toFixed(3);
const trap = ((a+b)*c / (2.0)).toFixed(3);
const quad = (b*b).toFixed(3);
const ret = (a*b).toFixed(3);

console.log(`TRIANGULO: ${areatri}`);
console.log(`CIRCULO: ${cir}`);
console.log(`TRAPEZIO: ${trap}`);
console.log(`QUADRADO: ${quad}`);
console.log(`RETANGULO: ${ret}`);