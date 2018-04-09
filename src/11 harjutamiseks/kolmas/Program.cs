using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmas
{
    //Ülesanne 2
    //Sul on programmis defineeritud massiiv järgnevate nimedega: 
    //Kaur, Mattias, Kristel, Heleri, Trevor, Kristjan, Kelli, Kevin, Maarika, Laura.
    //Programm küsib kasutaja käest sisendit. Sisendiks võib olla üks sõna, lause või miks mitte ka 10 lauset.
    //Ülesanne on kasutajale programmi lõpus kuvada tema sisestatud sisend, 
    // aga nii, et kõik nimed oleks kindlasti suure algustähega.
    //Näiteks kui kasutaja sisestab teksti: „kevin ja heleri mängisid koos liivakastis. 
    //trevor vaatas pealt ning kristel kiikus.“ siis tulemuseks peab olema: „Kevin ja Heleri mängisid koos liivakastis. 
    //Trevor vaatas pealt ning Kristel kiikus.“

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta siia üks sõna, lause või miks mitte ka 10 lauset. ");
            Console.WriteLine("Programm muudab sisestatud tekstis leiduvate nimede algust2hed suureks.");
            Console.WriteLine();

            string[] nimed = new string[10] { "kaur", "mattias", "kristel", "heleri", "trevor",
                "kristjan", "kelli", "kevin", "maarika", "laura" };

            string userInput = Console.ReadLine();

            //string userInput = "kevin ja heleri mängisid koos. kaur lebas liivakastis, " +
                //"tema all kristel ja kelli nang nende liiva sisse maetud nukud. " +
                //"trevor vaatas pealt ning kristel kiikus rõõmsameelselt laura ja kelli vingu ja virina taktis.";

            for (int i = 0; i < nimed.Count(); i++)
            {
                userInput = userInput.Replace(nimed[i], TeeSuureks(nimed[i]));
            }
        
            Console.WriteLine(userInput);
            Console.ReadLine();
        }

        static string TeeSuureks(string nimi) 
        {
            if (nimi.Length == 1)
                return nimi.ToUpper();
            return nimi.Remove(1).ToUpper() + nimi.Substring(1);
        }

        /*public static void FindWordandMakeBig(string userInput, string word, string millega)
        {
            StringBuilder builder = new StringBuilder();
            char firstLetter = word[0];
            bool eelmineLetter = false;
            int i = 0;
            while (i < userInput.Length - word.Lenght + 1)
            {
                bool leitudWord = false;
                char t2ht = userInput[i];
                if (t2ht == firstLetter && !eelmineLetter && userInput.Substring(i, word.Length).Equals(word)) ;
                {
                    leitudWord = true;
                    //bool completeWordLeitud = true;

                    if (leitudWord)
                    {
                        builder.Append(millega);
                    }
                    else
                    {
                        builder.Append(word);
                    }

                    i += word.Length;
                }
                if (!leitudWord)
                {
                    eelmineLetter = char.IsLetterOrDigit(firstLetter);
                    builder.Append(firstLetter);
                    i++;
                }
            }
            if (userInput.Length - i > 0)
            {
                builder.Append(userInput.Substring(i));
            }
            return builder.ToString();
        }
                                /*
                                    if (Char.IsLetterOrDigit(s[i + word.Length]))
                                        wholeWordFound = false;
                */
    }
}
