using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        private int cardValue;
        private int suit;
        public int Value { get { return cardValue; } set { cardValue = ValidateValue(value); } }
        public int Suit { get { return suit; } set { suit = ValidateSuit(value); } }
        public override string ToString()
        {
            string strRank = "";
            switch (Value)
            {
                case 1:
                    strRank = "Ace";
                    break;
                case 11:
                    strRank = "Jack";
                    break;
                case 12:
                    strRank = "Queen";
                    break;
                case 13:
                    strRank = "King";
                    break;
                default:
                    strRank = Convert.ToString(Value);
                    break;
            }
            string strSuit = "";
            switch (Suit)
            {
                case 1:
                    strSuit = "Diamonds";
                    break;
                case 2:
                    strSuit = "Clubs";
                    break;
                case 3:
                    strSuit = "Hearts";
                    break;
                case 4:
                    strSuit = "Spades";
                    break;
                default:
                    break;
            }
            return strRank + " of " + strSuit;
        }

        public Card(int value, int suit)
        {
            Value= value;
            Suit= suit;
        }

        private int ValidateSuit(int suit)
        {
            if (suit >= 5)
            {
                return 4;
            }
            else if (suit <= 0)
            {
                return 1;
            }
            return suit;
        }

        private int ValidateValue(int value)
        {
            if (value >= 14)
            {
                return 13;
            }
            else if (value <= 0)
            {
                return 1;
            }
            return value;
        }

    }
}
