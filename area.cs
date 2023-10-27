using System;

namespace MyCompiler
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double num = s.Length;
            double[] integers = new double[3];

            string[] splitado = s.Split(' ');

            for (int i = 0; i < splitado.Length; i++)
            {
                if (double.TryParse(splitado[i], out num))
                {
                    integers[i] = num;
                }
            }
            double a = integers[0];
            double b = integers[1];
            double c = integers[2];

            double areatri = (a * c) / 2.0;
            double areacirc = 3.14159 * c * c;
            double areatrap = (a + b) * c / 2.0;
            double areaquadr = b * b;
            double arearet = a * b;


            Console.WriteLine("TRIANGULO: {0:F3}", areatri);
            Console.WriteLine("CIRCULO: {0:F3}", areacirc);
            Console.WriteLine("TRAPEZIO: {0:F3}", areatrap);
            Console.WriteLine("QUADRADO: {0:F3}", areaquadr);
            Console.WriteLine("RETANGULO: {0:F3}", arearet);
        }
    }
}
