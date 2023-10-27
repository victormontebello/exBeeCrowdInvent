var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

var number, total;
            let st = "";
            var total,k=0;
            for (var i = 0; i < 3; i++)
            {
                total = 0;
                while (st != "caw caw")
                {
                    number = 0;
                    st = lines[k];
                    if (st == "--*")
                    {
                        number += 1;
                    }
                    else if (st == "-*-")
                    {
                        number += 2;
                    }
                    else if (st == "-**")
                    {
                        number += 3;
                    }
                    else if (st == "*--")
                    {
                        number += 4;
                    }
                    else if (st == "*-*")
                    {
                        number += 5;
                    }
                    else if (st == "**-")
                    {
                        number += 6;
                    }
                    else if (st == "***")
                    {
                        number += 7;
                    }
                    else
                    {
                        number += 0;
                    }
                    total += number;
                    k++;
                }
                console.log(`${total}`);
                st = "";
           }