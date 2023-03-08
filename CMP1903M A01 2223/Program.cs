using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            Pack.shuffleCardPack(1);
            Pack.dealCard(5);
            Console.WriteLine(Pack.deal());
            Console.ReadLine();
            
        }

    }
}

