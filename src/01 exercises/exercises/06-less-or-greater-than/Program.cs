using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta number {1 - 100} ja ma ütlen, kas number on suurem või väiksem");
            Console.WriteLine();

            Console.Write("Sinu number: ");
            string input = Console.ReadLine();

            int magicNumber = int.Parse(input);

            //arvuti valib numbri
            int number = 33;

            if (magicNumber < number)
            {
                Console.WriteLine("Sinu number on väiksem");
            }

            if (magicNumber > number)
            {
                Console.WriteLine("Sinu number on suurem");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            
        }
    }
}
