using System;

namespace MyCompiler
{
    class Program
    {

        public static void Main(string[] args)
        {
            //salariocombonus
            string name = Console.ReadLine();
            double fix = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double total = fix + vendas * 0.15;
            Console.WriteLine($"TOTAL = R$ {total:F2}");

        }
       
    }
}
