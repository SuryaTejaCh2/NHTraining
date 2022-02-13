using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUsingArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            ArrayList data = new ArrayList();

            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            foreach(var item in data)
            {
                sum = sum + Convert.ToInt32(item);
            }

            Console.WriteLine($"Sum of data is {sum}");

            Console.ReadLine();
        }
    }
}
