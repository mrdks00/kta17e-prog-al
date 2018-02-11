using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_exercise
{ 
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta n+1 hulk s6nu ja valin nende hulgast suvalise!");
            Console.WriteLine("Lopetamiseks sisesta -1.");
            Console.WriteLine();

            List<string> words = new List<string>();

            while (true)
            {
                Console.Write("Sisesta kohanimi: ");
                var input = Console.ReadLine();

                if (input == "-1") break;

                words.Add(input);
            }

            Console.WriteLine($"Sisestasid: {string.Join(", ", words)}");
            var randomIndex = new Random().Next(0, words.Count - 1);
            Console.WriteLine($"Valin nendest v2lja suvalise {words[randomIndex]}");


            Console.ReadLine();

            /*Console.WriteLine("Sisesta kohanimesid ja valin nende hulgast suvalise koha!");
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
            }*/

            Console.ReadLine();
        }
    }
}
