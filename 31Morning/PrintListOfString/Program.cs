using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintListOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            List<string> data = new List<string>();

            Console.Write("Enter list size: ");
            size = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i} element: ");
                data.Add(Console.ReadLine());
            }


            Console.WriteLine("For Loop");
            for (int i = 0; i < data.Count; i++)
                Console.WriteLine(data[i]);

            Console.WriteLine("\nForEach Loop");
            foreach (string s in data)
                Console.WriteLine(s);

            Console.WriteLine("\nLambda Expression");
            data.ForEach(p => Console.WriteLine(p));

            Console.ReadLine();
        }
    }
}
