var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split(' ');

const a = Number(lines[0]);
const b = Number(lines[1]);
const c = Number(lines[2]);
let maior=0, medi=0, min=0;

 //Como são 3 valores, não vi sentido inserir em um array e ordenar por métodos
if(a> b && b >= c)
            {
                maior = a;
                medi = b;
                min = c;

            }else if(a>c && c >= b)
            {
                maior = a;
                medi = c;
                min = b;
            }
            else if (b>c && c>=a)
            {
                maior = b;
                medi =  c;
                min = a;
            }else if(b>a && a>=c)
            {
                maior = b;
                medi = a;
                min = c;
            }else if (c>a && a >= b)
            {
                maior = c;
                medi = a;
                min = b;
            }
            else
            {
                maior = c;
                medi = b;
                min = a;
            }
   const perim = (a+b+c).toFixed(1);
   const area = ((a+b) * c / 2).toFixed(1);
            
  if((min+medi)>maior){
      console.log(`Perimetro = ${perim}`);
  }else{
      console.log(`Area = ${area}`);
  }     