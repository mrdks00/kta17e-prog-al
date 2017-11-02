using System;

namespace _03_autom_nr_valimine
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            Console.Write("Hei, arva ära number vahemikus 1-100: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine();

            if (magicNumber > number)
            {
                Console.WriteLine("Sinu number on väiksem.");
            }
            else if (magicNumber < number)
            {
                Console.WriteLine("Sinu number on suurem.");
            }
            else
            {
                Console.WriteLine("Tubli! Arvasid numbri ära!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
