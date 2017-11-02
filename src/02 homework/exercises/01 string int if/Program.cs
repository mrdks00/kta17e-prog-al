using System;

namespace _01_numbri_arvamine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, mängime üht mängu! Ma mõtlen ühe numbri vahemikus 1-100 ja Sina proovid selle ära arvata!");
            Console.WriteLine();

            Console.Write("Sinu number on: ");
     
            string input = Console.ReadLine();

            int number = int.Parse(input);

            Console.WriteLine();

            int MagicNumber = 27;

            if (MagicNumber < number)
            {
                Console.WriteLine("Sinu number on suurem.");
            }

            if (MagicNumber > number)
            {
                Console.WriteLine("Sinu number on väiksem.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            
        }
    }
}
