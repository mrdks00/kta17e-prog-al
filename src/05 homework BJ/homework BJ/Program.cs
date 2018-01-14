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

namespace homework_BJ
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
                    cards[card_id] = new Card(rank_id, suit_id);
                    rank_id++;
                    card_id++;
                }
                suit_id++;
            }
        }

        Random random = new Random();

        //KAARDIPAKI SEGAMINIE
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

        // TEKITAB PAKI
        public void Dump_deck()
        {
            foreach (Card kaart in cards)
            {
                kaart.CardName();
            }
        }

        int card_counter = -1;

        public Card NextCard()
        {
            card_counter++;
            return cards[card_counter];
        }
    }

    // KAART
    class Card
    {
        private int rank;
        private int suit;
        public int value;

        private string[] rank_names = new String[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private string[] suit_names = new String[4] { "C", "S", "D", "H" };

        public int[] rank_value = new int[13] { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        public Card(int _rank, int _suit)
        {
            rank = _rank;
            suit = _suit;
            value = rank_value[_rank];

            //Console.WriteLine("Suit {0} rank {1}", suit_names[_suit], rank_names[_rank]);
        }

        public void CardName()
        {
            Console.WriteLine("    {0} {1}", suit_names[suit], rank_names[rank]);
        }

        public string GetName()
        {
            return rank_names[rank] + suit_names[suit];
        }
    }

    class Hand
    {
        private Card[] cards = new Card[52];
        private bool isDealer = false;

        public void Dealer()
        {
            isDealer = true;
        }

        public void PrintHandFinal()
        {
            int loendur = 0;

            if (isDealer == true)
            {
                Console.Write("Dealer: ");
            }
            else
            {
                Console.Write("You: ");
            }

            while (loendur < kaarte_peos)
            {
                Console.Write("[" + cards[loendur].GetName() + "] ");
                loendur++;
            }

            Console.WriteLine();

            if (isDealer == true)
            {
                Console.WriteLine($"Dealer has {HandValue()} points");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"You have {HandValue()} points");
                Console.WriteLine();
            }
            // Console.WriteLine("Summa" + HandValue());
        }

        public int kaarte_peos = 0;

        public void TakeCard(Card saadud_kaart)
        {
            cards[kaarte_peos] = saadud_kaart;
            kaarte_peos++;
        }

        public void PrintHand()
        {
            int loendur = 0;

            if (isDealer == true)
            {
                Console.Write("Dealer: ");
            }
            else
            {
                Console.Write("You: ");
            }

            while (loendur < kaarte_peos)
            {
                if (isDealer == true && loendur == 0)
                {
                    Console.Write("[?] ");
                }
                else
                {
                    Console.Write("[" + cards[loendur].GetName() + "]");
                }
                loendur++;
            }
            Console.WriteLine();
        }

        public int HandValue()
        {
            int summa = 0;
            int loendur = 0;
            int ace_count = 0;

            while (loendur < kaarte_peos)
            {
                summa += cards[loendur].value;

                if (cards[loendur].value == 11)
                {
                    ace_count++;
                }
                loendur++;
            }

            while (summa > 21 && ace_count > 0)
            {
                ace_count--;
                summa -= 10;
            }
            return summa;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Deck kaardipakk;
                kaardipakk = new Deck();
                kaardipakk.Shuffle(1000);

                Hand dealer = new Hand();
                dealer.Dealer();
                Hand player = new Hand();

                bool m2ng_kestab = true;

                player.TakeCard(kaardipakk.NextCard());
                dealer.TakeCard(kaardipakk.NextCard());
                player.TakeCard(kaardipakk.NextCard());
                dealer.TakeCard(kaardipakk.NextCard());

                while (m2ng_kestab)
                {
                    player.PrintHand();
                    dealer.PrintHand();
                    Console.WriteLine();
                    Console.WriteLine("What to do [h]it [s]tay?");
                   
                    while (true)
                    {
                        string key = Console.ReadLine();
                        Console.WriteLine();
                        if (key == "h")
                        {
                            player.TakeCard(kaardipakk.NextCard());
                            if (dealer.HandValue() < 17)
                            {
                                dealer.TakeCard(kaardipakk.NextCard());
                            }
                            break;
                        }
                        else if (key == "s")
                        {
                            m2ng_kestab = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Come again?");
                            Console.WriteLine("What to do [h]it [s]tay");
                        }
                    }
                    if (player.HandValue() > 21)
                    {
                        m2ng_kestab = false;
                    }
                }

                player.PrintHandFinal();
                dealer.PrintHandFinal();

                if (player.HandValue() > 21)
                {
                    Console.WriteLine("You wentr bust!");
                }
                else if (player.HandValue() > dealer.HandValue())
                {
                    Console.WriteLine("You won!");
                }
                else if (player.HandValue() > dealer.HandValue())
                {
                    Console.WriteLine("You lost!");
                }
                else
                {
                    Console.WriteLine("Draw");
                }

                Console.WriteLine("Want to [p]lay again or [e]nd?");
            }
            while (Console.ReadLine() == "p");             
        }
    }      
}

