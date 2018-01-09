using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Palun sisesta oma nimi: ");
            string input = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Tere hommikust {input}!");

            Console.WriteLine();

            Console.WriteLine($"Hetkel on {System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek]}, " +
                $"{DateTime.Now}");

            // Console.WriteLine($"Hetkel on {DateTime.Now.DayOfWeek.ToString()}, {DateTime.Now}");

            Console.WriteLine();

            string password;
            int sisestused = 0;

            string õigeparool;
            õigeparool = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames[(int)DateTime.Now.DayOfWeek];

            do
            {
                Console.Write("Tänase päeva parool: ");
                password = Console.ReadLine();
                Console.WriteLine();

                if (password != õigeparool)
                    sisestused++;
                else
                    sisestused = 1;
            }

            while ((password != õigeparool) && (sisestused != 3));

            if (3 == sisestused)
                Console.WriteLine("Sisestasid parooli 3 korda valesti. Mine parem magama tagasi ja proovi homme uuesti!");
            else
                Console.WriteLine("Õige. Võid täna tööle minna küll!");

            Console.ReadLine();
        }
    }
}
