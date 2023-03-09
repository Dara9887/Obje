us ing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_A01_2223
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            string valueString;
            switch (Rank)
            {
                case Rank.Ace:
                    valueString = "Ace";
                    break;
                case Rank.Jack:
                    valueString = "Jack";
                    break;
                case Rank.Queen:
                    valueString = "Queen";
                    break;
                case Rank.King:
                    valueString = "King";
                    break;
                default:
                    valueString = ((int)Rank).ToString();
                    break;
            }

            return $"{valueString} of {Suit}";
        }
    }
}