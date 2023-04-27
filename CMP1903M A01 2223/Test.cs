using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
     class Test
    {
       public Test() {

            Pack pack = new Pack();

<<<<<<< HEAD
            Random random= new Random();
           int shuffle= random.Next(1,3);
            pack.shuffleCardPack(shuffle);
/*            Console.WriteLine(Pack.shuffleCardPack(shuffle));
*/         /*   foreach (Card card in Pack.dealCard(5))
            {
                Console.WriteLine(card);
            }
            Console.WriteLine(Pack.deal());*/
            threecards.gamebegins();
=======
            int shuffleType =0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter a number to shuffle the pack (1 - fisher yates, 2 - riffle, 3 - none): ");
                string userInp1 = Console.ReadLine();
                shuffleType = int.Parse(userInp1);
                if (shuffleType >= 1 && shuffleType <= 3)
                {
                    validInput = true;
                }
            }

            


            Console.WriteLine(Pack.shuffleCardPack(shuffleType));
            Console.WriteLine(Pack.dealCard(5));
            Console.WriteLine(Pack.deal());
>>>>>>> cf8371edc25557f3a058d0d41e338c7f4b89b1b7
            Console.ReadLine();
        }
    }
}
