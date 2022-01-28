using System;

namespace SumOfNNaturalNumbersForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialzing
            int input, sum = 0;

            //User Input
            Console.Write("Enter any number: ");
            input = Convert.ToInt32(Console.ReadLine());


            //Logic for sum of N natural numbers
            for (int i = 0; i <= input; i++)
            {
                sum = sum + i;
            }

            //Output
            Console.WriteLine($"Sum of {input} natural numbers are {sum}");

            Console.ReadLine();
        }
    }
}
