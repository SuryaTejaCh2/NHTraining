using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Queue
* *********************************************************************/

namespace QueueB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(10);
            data.Enqueue(20);
            data.Enqueue(30);

            for (int i = 0; i <= data.Count; i++)
                Console.WriteLine($"Element Remove {data.Dequeue()}");
            Console.WriteLine($"Element Peek {data.Peek()}");

            Console.ReadLine();

        }
    }
}
