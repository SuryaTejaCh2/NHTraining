using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, power=1, result=0;

            Console.Write("Enter First number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber <= 0 || secondNumber <= 0)
            {
                Console.WriteLine("Enter numbers greater then 0");
            }
            else
            {
                for (int i = 1; i <= secondNumber; i++)
                {
                    power = power * firstNumber;
                }
                Console.WriteLine($"{firstNumber} to the power of {secondNumber} is {power}");
            }

            Console.ReadLine();
        }
    }
}
