using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kohanimesid ja valin nende hulgast suvalise koha!");
            Console.WriteLine("Lopetamiseks sisesta [q].");
            Console.WriteLine();

            Console.Write("Sisesta kohanimi: ");
            string[] input = { Console.ReadLine() };
            string l6pp = "q";
            foreach (koht in input)
            {
                return n++;
            }

            Random random = new Random();

            do
            {
                Console.Write("Sisesta kohanimi: ");
                input = {Console.ReadLine()};
            }
                    
                n++;
            if (input == l6pp)
            {
                Console.WriteLine("Sisestasid need kohad: " + (kohanimed));
               
                Console.Write("Suvaline koht kuhu peaksid kohe minema on: " + (random.Next(0, kohanimed.Length));
                Console.WriteLine);
            }

            Console.ReadLine();

        }
   
    }
}
