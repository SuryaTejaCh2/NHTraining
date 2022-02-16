using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArrayUsingForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float avj;
            int[] data = new int[5];

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write("Enter Number: ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int d in data)
            {
                sum = sum + d;
            }

            avj = sum/data.Length;

            Console.WriteLine($"Sum of array numbers is {sum} and average is {avj}");

            Console.ReadLine();
        }
    }
}
