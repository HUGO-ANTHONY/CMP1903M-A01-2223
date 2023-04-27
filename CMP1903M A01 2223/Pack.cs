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
   
        

        public  bool shuffleCardPack(int typeOfShuffle)
        {
           /* switch (typeOfShuffle)
            {
                case 1:
                    Console.WriteLine("fisher yates");
                    riffleShuffle();
                    return true;
                    break;
                case 2:
                    Console.WriteLine("riffle");
                    fisherYatesShuffle();
                    return true;
                    break;
                case 3:
                    Console.WriteLine("no shuffle");
                    return true;
                default:
                    Console.WriteLine("none");
                    return false;
            }
<<<<<<< HEAD
            return true;*/
           if (typeOfShuffle == 1)
            {
                 riffleShuffle();
                return true;
            }
           else if(typeOfShuffle== 2)
            {
                fisherYatesShuffle();
                return true;
            }
           return false;
=======
>>>>>>> cf8371edc25557f3a058d0d41e338c7f4b89b1b7
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
