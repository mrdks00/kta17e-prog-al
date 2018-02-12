using System;

namespace täringud
{
    class Dice
    {
        // [access modifier] [return type] [nimi] [(parameters)]
        public int Roll(int sides)
        {
            var random = new Random();

            return random.Next(1, sides + 1);
        }

    }
}
