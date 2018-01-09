using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*KAARDINIMED (rank id = card name)
 0 = Ace
 1 = 2
 2 = 3
 3 = 4
 4 = 5
 5 = 6
 6 = 7
 7 = 8
 8 = 9
 9 = 10
 10 = Jack
 11 = Queen
 12 = King

 KAARDIMASTID (suit id = suit name)
 0 = clubs
 1 = spades
 2 = diamonds
 3 = hearts*/

namespace Blackjack
{
    //KAARDIPAKK
    class Deck 
    {
        private Card[] cards = new Card[52];

        public Deck()
        {
            int rank_id;
            int suit_id;
            int card_id;

            suit_id = 0;
            card_id = 0;

            while (suit_id <= 3)
            {
                rank_id = 0;

                while (rank_id <= 12)
                {
                    cards[card_id] = new Card (rank_id, suit_id);
                    rank_id++;
                    card_id++;
                }
                suit_id++;
            }     
        }

        //KAARDIPAKI SEGAMINIE
        Random random = new Random();

        public void Shuffle(int vahetuste_arv)
        {
            int vahetusi_tehtud = 0;
            Card kaardi_parkla;
            int esimene_vahetaja, teine_vahetaja;

            while (vahetusi_tehtud < vahetuste_arv)
            {   
                esimene_vahetaja = random.Next(0, 51);
                teine_vahetaja = random.Next(0, 51);

                kaardi_parkla = cards[esimene_vahetaja];
                cards[esimene_vahetaja] = cards[teine_vahetaja];
                cards[teine_vahetaja] = kaardi_parkla;
                vahetusi_tehtud++;
            }
        }

        public void Dump_deck()
        {
            foreach(Card kaart in cards)
            {
                kaart.MyName();
            }
        }
    }

    class Card
    {
        private int rank;
        private int suit;

        private string[] rank_names = new String[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private string[] suit_names = new String[4] { "Clubs", "Spades", "Diamonds", "Hearts" };

        public Card(int _rank, int _suit)
        {
            rank = _rank;
            suit = _suit;

            //Console.WriteLine("Suit {0} rank {1}", suit_names[_suit], rank_names[_rank]);
        }

        public void MyName()
        {
            Console.WriteLine("{0} {1}", suit_names[suit], rank_names[rank]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Deck kaardipakk;
            kaardipakk = new Deck();
            kaardipakk.Shuffle(0);
            kaardipakk.Dump_deck();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            
            /*OUTPUT
            You have been dealt: 4C, 6H
            Dealer has been dealt: 8S, [?]

            What do you want to do?
            Choose: 1 - To take another card
            Choose: 2 - To finish

            You choose: 1

            You have been dealt: 45
            Dealer has been dealt: [?]

            What do you want to do?
            Choose: 1 - To take another card
            Choose: 2 - To finish

            You choose: 2

            You have 14 points vs. house 17 points
            Dealer wins!
            
            start the game again!!! */
        }
    }
}
