using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersUsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**********************************************************************
             * Author: Surya Teja
             * Purpose: Declare and initialize a list with 8 values. write for loop, foreach loop, lambda, linq query to print even numbers.
             * *********************************************************************/
            
            List<int> data = new List<int>() { 2, 5, 88, 66, 3, 44, 97, 11 };

            //For Loop
            Console.WriteLine("********************For Loop*******************");
            Console.Write($"Even numbers are: ");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i]%2 == 0)
                    Console.Write($"{data[i]}, ");
            }

            //ForEach Loop
            Console.WriteLine("\n*****************ForEach Loop******************");
            Console.Write($"Even numbers are: ");
            foreach (int d in data)
            {
                if(d%2 == 0)
                    Console.Write($"{d}, ");
            }

            //Lambda Expression
            Console.WriteLine("\n***************Lambda Expression***************");
            Console.Write($"Even numbers are: ");
            data.Where(d=>d%2 == 0).ToList().ForEach(d=>Console.Write($"{d}, "));

            //LINQ Query
            Console.WriteLine("\n*******************LINQ Query******************");
            Console.Write($"Even numbers are: ");
            var result = from d in data
                         where d%2 == 0
                         select d;
            result.ToList().ForEach(d => Console.Write($"{d}, "));
            
            Console.ReadLine();
        }
    }
}
