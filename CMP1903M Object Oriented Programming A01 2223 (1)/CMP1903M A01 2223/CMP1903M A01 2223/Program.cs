using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new pack of cards
            Pack pack = new Pack();

            // Shuffle the pack
            pack.ShuffleCardPack(1);

            // Deal a card
            Card card1 = pack.Deal();
            Console.WriteLine("Dealt card: {0}", card1);

            // Deal multiple cards
            List<Card> cards = pack.DealCard(5);
            Console.WriteLine("Dealt cards:");
            foreach (Card card in cards)
            {
                Console.WriteLine("- {0}", card);
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

