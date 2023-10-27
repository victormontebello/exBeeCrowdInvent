using System;

namespace MyCompiler
{
    class Program
    {
        public static void Main(string[] args)
        {
            //caw caw
            int number, total;
            string st = "";
            total = 0;
            for (int i = 0; i < 3; i++)
            {
                total = 0;
                while (st != "caw caw")
                {
                    number = 0;
                    st = Console.ReadLine();
                    number += st == "--*" ? 1 : 0;
                    number += st == "-*-" ? 2 : 0;
                    number += st == "-**" ? 3 : 0;
                    number += st == "*--" ? 4 : 0;
                    number += st == "*-*" ? 5 : 0;
                    number += st == "**-" ? 6 : 0;
                    number += st == "***" ? 7 : 0;
                    total += number;
                }
                Console.WriteLine(total);
                st = "";
           }
        }
     }
 }