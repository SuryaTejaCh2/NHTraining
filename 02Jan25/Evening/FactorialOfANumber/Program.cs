using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialzing
            int input, fact = 1;

            //User Input
            Console.Write("Enter any Number to find Factorial: ");
            input = Convert.ToInt32(Console.ReadLine());

            //Logic
            for(int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }

            //Output
            Console.WriteLine($"Factorial of {input} is {fact}");

            Console.ReadLine();
        }
    }
}
