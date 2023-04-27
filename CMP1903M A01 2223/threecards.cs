using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class threecards
    {
        public static double gamebegins()
        {
            List<Card> cards = Pack.dealCard(3);
         /*   foreach (Card card in cards)
            {
                Console.WriteLine(card.Value);
            }*/
            if (cards[1].Suit == 1)
            {
                int answer = cards[0].Value + cards[1].Value;
                Console.WriteLine($"{cards[0].Value} + { cards[1].Value} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == answer)
                {
                    Console.WriteLine("Correct !!");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Wrong answer");
                    return answer;
                }

            }
            else if (cards[1].Suit == 2)
            {
                int answer = cards[0].Value - cards[1].Value;
                Console.WriteLine($"{cards[0].Value - cards[1].Value} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == answer)
                {
                    return 1;
                }
                else
                {
                    return answer;
                }

            }
            else if (cards[1].Suit == 3)
            {
                int answer = cards[0].Value / cards[1].Value;
                Console.WriteLine($"{cards[0].Value / cards[1].Value} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == answer)
                {
                    return 1;
                }
                else
                {
                    return answer;
                }

            }
            else if (cards[1].Suit == 4)
            {
                int answer = cards[0].Value * cards[1].Value;
                Console.WriteLine($"{cards[0].Value * cards[1].Value} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == answer)
                {
                    return 1;
                }
                else
                {
                    return answer;
                }

            }

            return 0;
        }
    }
}
