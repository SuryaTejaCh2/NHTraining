using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Write C# program to read two numbers from use and print
                a. sum of two numbers
                b. difference of two numbers
                c. product of two numbers
                d. division of two numbers.
* *********************************************************************/

namespace MathOperations
{
    public class Operators
    {
        private int firstNumber;
        private int secondNumber;
        /// <summary>
        /// Reading Numbers from user 
        /// </summary>
        public void ReadData()
        {
            Console.Write("Enter First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Adding two numbers
        /// </summary>
        /// <returns>sum of two numbers</returns>

        public int Addition()
        {
            return firstNumber + secondNumber;
        }

        /// <summary>
        /// Subract two numbers
        /// </summary>
        /// <returns>Difference of two numbers</returns>

        public int Difference()
        {
            return firstNumber - secondNumber;
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <returns>Product of two numbers</returns>

        public int Product()
        {
            return firstNumber * secondNumber;
        }/// <summary>
        /// Divide two numbers
        /// </summary>
        /// <returns>Division of two numbers</returns>
          
        public int Division()
        {
            return firstNumber / secondNumber;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();
            op.ReadData();
            Console.WriteLine($"Addition of two numbers are {op.Addition()}.");
            Console.WriteLine($"Difference of two numbers are {op.Difference()}.");
            Console.WriteLine($"Product of two numbers are {op.Product()}.");
            Console.WriteLine($"Divison of two numbers are {op.Division()}.");

            Console.ReadLine();
        }
    }
}
