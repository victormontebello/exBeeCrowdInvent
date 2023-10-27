var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split(' ');

const a = Number(lines[0]);
const b = Number(lines[1]);
const c = Number(lines[2]);

const delta = b*b - (4*a*c);

if(delta>=0 && a!=0){
    r1 = ((-b + Math.sqrt(delta))/(2*a)).toFixed(5);
    r2 = ((-b - Math.sqrt(delta))/(2*a)).toFixed(5);
    console.log(`R1 = ${r1}`);
    console.log(`R2 = ${r2}`);
}else{
    console.log(`Impossivel calcular`);
    }