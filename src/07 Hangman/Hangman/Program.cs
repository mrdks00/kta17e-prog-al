using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] pildid = new string[7] {
            "      _______\n     |/      |\n     |      (_)\n     |      \\|/\n     |       |\n     |      / \\\n     |\n    _|___\n",
            " \n             \n            (_)\n            \\|/\n             |\n            / \n      \n\n",
            " \n             \n            (_)\n            \\|/\n             |\n            \n      \n\n",
            " \n             \n            (_)\n            \\ /\n             \n            \n      \n\n",
            " \n             \n            (_)\n            \\ \n             \n            \n      \n\n",
            " \n             \n            (_)\n             \n            \n      \n   \n\n",
            " \n             \n            \n             \n            \n      \n   \n\n",
        };

        string word;
        string kuvatav = "";
        int letter_counter = 0;
        string input;
        int elu_count = 6;
        Random random = new Random();

        string[] words = File.ReadAllLines("./dictionary.txt");

        word = words[random.Next(words.Length)].ToUpper();

        do
        {
            kuvatav += "-";
            letter_counter++;
        }
        while (letter_counter < word.Length);

        while (true)
        {
            Console.Clear();
            Console.Write(pildid[elu_count]);
            Console.Write("       " + kuvatav + "\n      Guess: ");
            input = Console.ReadLine().ToUpper();

            if (input.Length < 1)
            {
                continue;
            }

            bool hasCharacter = (word.IndexOf(input) > -1); //nii on arusaadavam ka teistele
            if (true)
            {
                foreach (Match match in Regex.Matches(word, input))
                {
                    char[] ajutine = kuvatav.ToCharArray();
                    ajutine[match.Index] = match.Value[0];
                    kuvatav = new String(ajutine);
                }
            }
            else
            {
                elu_count--;
            }

            if (kuvatav == word)
            {
                Console.WriteLine("win");
                break;
            }
            if (elu_count == 0)
            {
                Console.Clear();
                Console.Write(pildid[elu_count]);
                Console.WriteLine("       " + word + "\n      You got hung!");
                break;
            }
        }
        Console.ReadLine();
    }
}