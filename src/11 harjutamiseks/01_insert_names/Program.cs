using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_insert_names
{
    //Luua programm mis küsib inimeste nimesi niikaua kuni sisestatakse erimärk „-1“. 
    //Iga sisestatud nimi lisatakse massiivi mis kuvatakse kasutajale programmi lõpus välja.
    //Kindlasti tuleb veenduda, et esimene täht oleks suur.Selle võid lahendada nii, 
    //et palud kasutajal sisestada sisendi õigel kujul 
    //või siis vaikimisi teed programmis esimese tähe alati suureks.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert names or [-1] to see all names");
            Console.WriteLine();

            List<string> Nimekiri = new List<string>();
            string sisestus;

            do
            {
                Console.Write("> ");

                sisestus = Console.ReadLine();

                if (sisestus == "-1")
                {
                    break;
                }

                Nimekiri.Add(CapitalizeFirstLetter(sisestus));

            } while (true);

            string sisestatudNimed = string.Join(", ", Nimekiri.ToArray());

            Console.WriteLine();

            Console.WriteLine($"all: {sisestatudNimed}");

            Console.ReadLine();
        }

        static string CapitalizeFirstLetter(string nimi) //meetod(tegelt on see ka funktsioon, lihtsalt eriline nagu ruut) 
        {
            if (nimi.Length == 1)
                return nimi.ToUpper();
            return nimi.Remove(1).ToUpper() + nimi.Substring(1);
        }
    }
}

