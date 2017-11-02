using System;

namespace _02_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hei, arva ära number vahemikus 1-100: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine();

            int MagicNumber = 55;

            if (MagicNumber < number)
            {
                Console.WriteLine("Sinu number on suurem.");
            }

            if (MagicNumber > number)
            {
                Console.WriteLine("Sinu number on väiksem.");
            }

            else
            {
                Console.WriteLine("Arvasid numbri ära. Tubli!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
