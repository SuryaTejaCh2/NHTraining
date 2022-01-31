using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfListInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, sum  = 0, sum1 = 0, sum2 = 0;
            List<int> data = new List<int>();

            Console.Write("Enter list size: ");
            size = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i} element: ");
                data.Add(Convert.ToInt32(Console.ReadLine()));
            }

            
            //For Loop
            for (int i = 0; i < data.Count; i++)
                sum = sum + data[i];

            //ForEach Loop
            foreach (int n in data)
                sum1 = sum1 + n;

            //Lambda Expression
            data.ForEach(x => sum2 = sum2 + x);

            Console.WriteLine("\nFor Loop");
            Console.WriteLine(sum);
            Console.WriteLine("\nForEach Loop");
            Console.WriteLine(sum1);
            Console.WriteLine("\nLambda Expression");
            Console.WriteLine(sum2);

            Console.ReadLine();
        }
    }
}
