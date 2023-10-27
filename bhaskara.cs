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

            double delta = (b * b) - (4 * a * c);

            if (delta>0 && a!=0) {

                double r1 = (-b + Math.Sqrt(delta))/(2.0*a);
                double rs = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine($"R1 = {r1:F5}");
                Console.WriteLine($"R2 = {rs:F5}");

            }
            else
            {
                Console.WriteLine("Impossivel calcular");

            }

        }
    }
}
