using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private static List<Card> cards;

        public Pack()
        {
            cards = new List<Card>();
            for (int suit = 1; suit <= 4; suit++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    cards.Add(new Card(i, suit));
                }
            }
        }
   
        

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            switch (typeOfShuffle)
            {
                case 1:
                    riffleShuffle();
                    break;
                case 2:
                    fisherYatesShuffle();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void fisherYatesShuffle()
        {
            int n = cards.Count;
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                int j = rand.Next(n);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        private static void riffleShuffle()
        {
            List<Card> shuffledPack = new List<Card>();
            int n = cards.Count;
            List<Card> Pack1 = cards.GetRange(0,cards.Count/2);
            List<Card> Pack2 = cards.GetRange(cards.Count / 2, cards.Count / 2);
            for (int i = 0; i < Pack1.Count; i++)
            {
                shuffledPack.Add(Pack1[i]);
                shuffledPack.Add(Pack2[i]);

            }
            cards = shuffledPack;
        }

        public static Card deal()
        {
            if (cards.Count > 0)
            {
                Card card = cards[0];
                cards.RemoveAt(0);
                return card;
            }
            return null;
        }

        public static List<Card> dealCard(int amount)
        {
            List<Card> dealtCards = new List<Card>();
            for (int i = 0; i < amount; i++)
            {
                dealtCards.Add(cards[i]);

            }
            foreach (Card item in dealtCards)
            {
                cards.Remove(item);
            }
            return dealtCards;
        }
      
    }
}
