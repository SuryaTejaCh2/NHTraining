using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: ContinueAndBreak
* *********************************************************************/

namespace ContinueAndBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //print numbers from 1 to 30 and skip the numbers divisible by 3
            Console.Write("Numbers divisible by 3: ");
            for(int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.Write($"{i} ");
            }
            */
            int i;
            for(i = 1000; i <= 2000; i++)
            {
                if (i % 97 == 0)
                    break;
            }
            Console.WriteLine($"First number after 1000 divisible by 97 is {i}");

            Console.ReadLine();
        }
    }
}
