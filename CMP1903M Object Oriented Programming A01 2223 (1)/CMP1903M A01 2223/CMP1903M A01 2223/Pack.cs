using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> pack;

        public Pack()
        {
            // Initialize the card pack here
            this.pack = new List<Card>();

            // Add all the cards to the pack
            foreach (suit Suit in Enum.GetValues(typeof(suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                { 
                    this.pack.Add(new Card(Suit, rank));
                }
            }
        }

        public bool ShuffleCardPack(int typeOfShuffle)
        {
            // Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle)
            {
                case 1:
                    // Perform a simple shuffle
                    this.pack = this.pack.OrderBy(x => Guid.NewGuid()).ToList();
                    break;

                case 2:
                    // Perform a more complex shuffle
                    // ...
                    break;

                default:
                    // Invalid shuffle type
                    return false;
            }

            return true;
        }

        public Card Deal()
        {
            // Deals one card
            if (this.pack.Count == 0)
            {
                throw new InvalidOperationException("The card pack is empty");
            }

            Card card = this.pack[0];
            this.pack.RemoveAt(0);
            return card;
        }

        public List<Card> DealCard(int amount)
        {
            // Deals the number of cards specified by 'amount'
            if (amount > this.pack.Count)
            {
                throw new InvalidOperationException("Not enough cards in the pack");
            }

            List<Card> cards = this.pack.Take(amount).ToList();
            this.pack.RemoveRange(0, amount);
            return cards;
        }
    }
}