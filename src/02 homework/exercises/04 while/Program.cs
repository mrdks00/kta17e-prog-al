using System;

namespace _04_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, arva ära number vahemikus 1-100!");
            Console.WriteLine();

            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int allowed_attemps = 100;
            while (allowed_attemps > 0)

            {
                Console.Write("Sinu number: ");

                string input = Console.ReadLine();
                int number = int.Parse(input);

                Console.WriteLine();

                if (magicNumber > number)
                {
                    Console.WriteLine($"Sisestasid {number}, see on väiksem, kui minu number. Proovi uuesti!");
                }
                else if (magicNumber < number)
                {
                    Console.WriteLine($"Sisestasid {number}, see on suurem, kui minu number. Proovi uuesti!");
                }
                else
                {
                    Console.WriteLine($"Sisestasid {number}. Arvasid numbri ära. Tubli!");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
