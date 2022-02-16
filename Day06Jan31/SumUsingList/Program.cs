using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> data = new List<int>();

            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);
            
            foreach (int l in data)
            {
                sum = sum + l;
            }

            Console.WriteLine($"Sum of values in List is {sum}");

            Console.ReadLine();
        }
    }
}
