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
            Console.ReadLine();
        }
    }
}
