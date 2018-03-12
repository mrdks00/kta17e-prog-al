using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letter = new string[32] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q", "R", "S", "Š", "Z", "Ž", "T", "U", "V", "W",
            "Õ", "Ä", "Ö", "Ü", "X", "Y" };
            //proovi kodus salaja lihtsamatel viisidel nagu nt 'abcdef' tavalise arrayga

            string[] output_letter = new string[32] {"C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q", "R", "S", "Š", "Z", "Ž", "T", "U", "V", "W",
            "Õ", "Ä", "Ö", "Ü", "X", "Y", "A", "B"};

            Console.WriteLine("word: ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine($"{input}");
            char[] input_letter = input.ToCharArray();
            var in_letter_index = Array.IndexOf(letter, input_letter);


            foreach (char input_letter_index in input_letter)
            {
                Console.WriteLine($"{Array.IndexOf(letter, input_letter_index)}");
                //int index = Array.IndexOf(letter, input_letter_index);
                    
                //    //Console.Write("{output_letter}", Array.IndexOf(output_letter, input_letter_index);
                //    Console.WriteLine($"{output_letter[index]}");
                    
            }
            Console.ReadKey();
        }
    }
}
