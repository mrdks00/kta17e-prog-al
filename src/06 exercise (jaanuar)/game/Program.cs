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
            " \n             \n            (_)\n            \\ \n             \n            \n      \n\n" +
            "",
            " \n             \n            (_)\n             \n            \n      \n   \n\n",
            " \n             \n            \n             \n            \n      \n   \n\n",
        };

        string arvatav;
        string kuvatav = ""; //osaliselt ära arvatud sõna, mille me ekraanile kuvame
        int luger = 0;
        string pakuti;
        int elud = 6;
        Random random = new Random();

        string[] words = File.ReadAllLines("./dictionary.txt");
        /*new String[46] {"followed", "provided", "although", "happened", "question",
        "American", "increase", "received", "anything", "industry", "religion", "building",
        "interest", "remember", "business", "involved", "required", "children", "national",
        "services", "complete", "organize", "southern","consider", "personal", "standard",
        "continue", "planning", "strength", "couldn't", "position", "students","decision",
        "possible", "suddenly", "directly", "pressure", "thinking", "district", "probably",
        "together","economic", "problems", "training", "evidence", "programs"};*/

        arvatav = words[random.Next(words.Length)].ToUpper();

        do
        {
            kuvatav += "-";
            luger++;
        }
        while (luger < arvatav.Length);

        while (true)
        {
            Console.Clear();
            Console.Write(pildid[elud]);
            Console.Write("       " + kuvatav + "\n      Guess: ");
            pakuti = Console.ReadLine().ToUpper();


            if (pakuti.Length < 1)
            {
                continue;
            }
            if (arvatav.IndexOf(pakuti) > -1)
            {
                foreach (Match match in Regex.Matches(arvatav, pakuti))
                {
                    char[] ajutine = kuvatav.ToCharArray();
                    ajutine[match.Index] = match.Value[0];
                    kuvatav = new String(ajutine);
                }
            }
            else
            {
                elud--;
            }


            if (kuvatav == arvatav)
            {

                Console.WriteLine("win");
                break;
            }
            if (elud == 0)
            {

                Console.Clear();
                Console.Write(pildid[elud]);
                Console.WriteLine("       " + arvatav + "\n      You got hung!");
                break;
            }

        }
        Console.ReadKey();
    }

}


/*namespace ConsoleHangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are playing Hangman!");
            Console.WriteLine("Quess the letters.. one by one");
        }
 
        private string[] words = new String[46] {"followed", "provided", "although", "happened", "question",
            "American", "increase", "received", "anything", "industry", "religion", "building",
            "interest", "remember", "business", "involved", "required", "children", "national",
            "services", "complete", "organize", "southern","consider", "personal", "standard",
            "continue", "planning", "strength", "couldn't", "position", "students","decision",
            "possible", "suddenly", "directly", "pressure", "thinking", "district", "probably",
            "together","economic", "problems", "training", "evidence", "programs" };
 
        int word_index = 0;
 
        if (word_index == i && word_index <= words.getLength)
        {
            return index
    }
 
    public void Insert(int index, object word)
    {
        Random random = new Random();
        var word = random.Next(0, words.Count());
 
        IndexOf(random_word);
        Count.random_word
 
            Console.WriteLine("__________");
        Console.WriteLine("Your letter: ");
 
        var input_letter = Console.Read();
        int input_count = 0;
 
    }
 
    public Word new_Word()
    {
        var choosen_word = new int(random.Next(0, Word.words(Count);
    }
 
    private int letter;
 
    private Letter[] letter_id = new letter[32];
 
    public string[] letters = new String[32] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q", "R", "S", "Š", "Z", "Ž", "T", "U", "V", "W", "Õ", "Ä", "Ö", "Ü", "X", "Y" };
 
    letters get..setkjsagkjn
 
 
    int letter_id = 0;
    letter_id++;
          Console.WriteLine("If you want to play again press [y]es..");
}
    }
    }*/
