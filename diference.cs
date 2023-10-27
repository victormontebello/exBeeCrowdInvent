using System;

namespace MyCompiler
{
    class Program
    {

        public static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
              
            int dif = diference(a, b, c, d);
            Console.WriteLine($"DIFERENCA = {dif}");

        }
        static int diference(int a, int b, int c, int d)
        {
            return (a * b) - (c * d);
        }
    }
}
