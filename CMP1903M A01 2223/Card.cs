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
        public int Value { get; set; }
        public int Suit { get; set; }
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

    }
}
