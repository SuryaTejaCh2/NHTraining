using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Factorial Recursion
* *********************************************************************/

namespace FactorialRecursion
{
    internal class Program
    {
        class Factorial
        {
            public int Fact(int number)
            {
                if (number == 1)
                    return 1;
                else
                    return number * Fact(number - 1);
            }
        }
        static void Main(string[] args)
        {
            int input;

            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            Factorial f = new Factorial();
            Console.WriteLine($"Fact is {f.Fact(input)}");

            Console.ReadLine();
        }
    }
}
