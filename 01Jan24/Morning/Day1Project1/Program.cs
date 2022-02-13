using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, result=0;

            Console.Write("Enter First number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            result = firstNumber + secondNumber;

            Console.WriteLine($"Sum of {firstNumber} and {secondNumber} numbers is {result}");

            Console.ReadLine();
        }
    }
}
