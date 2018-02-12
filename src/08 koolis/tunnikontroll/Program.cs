using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            //see programm vahetab sõnades ära tähtede järjekorra, 
            //aga jätab esimese ja viimase tähe oma kohale.

            Console.Write(">");
            string word = Console.ReadLine();

            StringBuilder sb = new StringBuilder(word);
            sb.Remove(1, word.Length - 2);

            //Console.WriteLine("{0}", sb.ToString());
            //Console.ReadKey();

            List<int> indexes = new List<int>();
            char[] split = word.ToCharArray();
            Random rand = new Random();
            int randIndex = 0;
            var outcome;

            for (int i = 0; i < word.Length; i++)
            {
                randIndex = rand.Next(0, word.Length);

                if (!indexes.Contains(randIndex))
                {
                    indexes.Add(randIndex);
                }
                else
                {
                    i--;
                }
            }

            foreach (int value in indexes)
            {
                outcome += split[value];
            }

            sb.Insert(1, word.Length - 2);

            Console.WriteLine();
            Console.ReadLine();


        }
    }
}