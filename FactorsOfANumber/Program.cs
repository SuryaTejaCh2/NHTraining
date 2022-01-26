using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsOfANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialzing
            int input;

            //User Input
            Console.Write("Enter any Number to find Factors of a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            //Logic and Output
            Console.Write($"Factors of {input} are  ");
            for (int i = 1; i <= input; i++)
            {
                if(input%i == 0)
                {
                    Console.Write($"{i}  ");
                }
            }


            Console.ReadLine();
        }
    }
}
