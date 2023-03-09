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

            Console.WriteLine(Pack.shuffleCardPack(1));
            Console.WriteLine(Pack.dealCard(5));
            Console.WriteLine(Pack.deal());
            Console.ReadLine();
        }
    }
}
