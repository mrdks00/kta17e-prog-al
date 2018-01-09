using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_consumption_LED_stripe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tegin kalkulaatori kahe enim kasutatava LED riba vooluvajaduse arvutamiseks.

            Console.WriteLine("12V toitega LED riba vooluvajaduse kalkulaator");
            Console.WriteLine();

            Console.WriteLine("Alustuseks vali LED chip, mida ribas kasutatakse:");
            Console.WriteLine();

            Console.WriteLine("A: SMD5050 / 5mm * 5mm kiip, mis koosneb omakorda 3-4 pisikesest LEDist");
            Console.WriteLine("B: SMD3528 / 3,5mm * 2,8mm kiip");
            Console.WriteLine();

            string valik;
            valik = Console.ReadLine().ToString().ToUpper();

            string ledarv;
            ledarv = Console.ReadLine();
            int arv = int.Parse(ledarv);


            Console.WriteLine("Mitu LED kiipi on ribal ühe meetri kohta?");
            Console.WriteLine();

            if (valik == "A")
            {
                Console.WriteLine("30, 60, 120");
                Console.WriteLine();
            }
            else if (valik == "B")
            {
                Console.WriteLine("60, 120");
                Console.WriteLine();
            }

            string pikkus;
            pikkus = Console.ReadLine();
            int pikk = int.Parse(pikkus);

            Console.WriteLine("Milline on LED riba/ribade kogupikkus?");
            Console.WriteLine();

            if (valik == "A")
            {
                Console.WriteLine($"{pikkus} meetri LED riba toiteks läheb vaja vähemalt:" +
                    $" {arv * pikk * 0,24} W ja {arv * pikk * 0,24 / 12} A");
            }
            else if (valik == "B")
            {
                Console.WriteLine($"{pikkus} meetri LED riba toiteks läheb vaja vähemalt: ");
                Console.WriteLine($"{arv * pikk * 0,08} watti ");
                Console.WriteLine($"Mis on {arv * pikk * 0,08 / 12} amprit");
            }
        }
    }
}
