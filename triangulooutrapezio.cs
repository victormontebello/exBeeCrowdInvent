using System;

namespace MyCompiler
{
    class Program
    {

        public static void Main(string[] args)
        {
            //bhaskara

            string[] values = Console.ReadLine().Split(' ');
            double a = double.Parse(values[0]);
            double b = double.Parse(values[1]);
            double c = double.Parse(values[2]);
            double maior, medi, min;
           
            //Como são somente 3 valores, não vi sentido inserir em array e ordenar;
           
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
            
            bool tri = sertri(maior, medi, min);
            double area;

            if (tri)
            {
                double perim = a + b + c;
                Console.WriteLine($"Perimetro = {perim:F1}");
            }
            else {
                area = ((a + b) * c) / 2.0;
                Console.WriteLine($"Area = {area:F1}");
            }

        }

        static bool sertri(double maior, double b, double c)
        {
            if ((b + c) > maior)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
