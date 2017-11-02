using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina olen kalkulaatori programm. Ütle mulle 2 numbrit ja ma ütlen sulle nende summa!");
            Console.WriteLine();

            Console.Write("Esimene number:");
            string input = Console.ReadLine();

            Console.Write("Teine number:");
            string input1 = Console.ReadLine();
            Console.WriteLine();

            int number1 = int.Parse(input);
            int number2 = int.Parse(input1);

            //int tulemus = number 1 + number2

            Console.WriteLine("Tulemuseks on:" + (number1 + number2));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");

            Console.ReadLine();
        }
    }
}
