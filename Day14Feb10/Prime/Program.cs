using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;

            Console.Write("Enter number to calculate prime: ");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                Console.WriteLine($"{input} is prime number.");
            else
                Console.WriteLine($"{input} is not prime number.");

            Console.ReadLine();
        }
    }
}
