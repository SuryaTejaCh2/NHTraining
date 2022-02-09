using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Stack
* *********************************************************************/

namespace StackB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(10);
            data.Push(20);
            data.Push(30);

            for (int i = 0; i <= data.Count; i++)
                Console.WriteLine($"Element Pop {data.Pop()}");
            Console.WriteLine($"Element Peek {data.Peek()}");

            Console.ReadLine();
        }
    }
}
