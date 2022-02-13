using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Write a C# program to read input from user and print
                a. factorial of a number
                b. factors of a number
                c. check if it prime or not
* *********************************************************************/


namespace MathProblems
{
    public class Problems
    {
        private int input;

        /// <summary>
        /// User input for MathProblems.
        /// </summary>
        public void ReadData()
        {
            Console.Write("Enter Number: ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Factorial of user input
        /// </summary>
        public void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
                fact = fact * i;
            Console.WriteLine($"Factorial of {input} is {fact}.");
        }
        /// <summary>
        /// Factors of user input
        /// </summary>
        public void Factors()
        {
            Console.Write($"Factors of {input} are ");
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Prime of user input
        /// </summary>
        public void Prime()
        {
            int i;
            for(i = 2;i <= input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                Console.WriteLine($"{input} is a Prime number");
            else
                Console.WriteLine($"{input} is not a Prime number");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Problems prob = new Problems();
            prob.ReadData();
            prob.Factorial();
            prob.Factors();
            prob.Prime();

            Console.ReadLine();
        }
    }
}
