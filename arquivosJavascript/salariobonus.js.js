var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const name = lines[0];
const fix = Number(lines[1]);
const vendas = Number(lines[2]);
const tot = fix + (vendas*0.15);
const hug = tot.toFixed(2);
console.log(`TOTAL = R$ ${hug}`);