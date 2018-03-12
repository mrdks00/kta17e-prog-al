using System;

namespace tunnikontrolli_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jaanalind > jnaailand");
            Console.WriteLine(">");

            string[] splitted = words.Split(' ');

            foreach (var word in splitted)
            {
                char firstChar = word[0];
                char lastChar = word[word.Length - 1];
                string original = word.Substring(1, word.Length - 2);
                string mixed = original;

                while (mixed == original)
                {
                    Console.Write(Shuffle.Stringmixer(word) + " ");

                    Console.Write($"{firstChar}{original}{lastChar}");
                }
            }

            Console.ReadKey();
        
        }
    }
}
