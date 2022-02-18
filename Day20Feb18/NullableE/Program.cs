using System;

/**********************************************************************
* Author: Surya Teja
* Purpose: WACP to illustrate nullable types
* *********************************************************************/

namespace NullableE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? FirstNumber = 25;
            int? SecondNumber = null;

            Console.Write("First Number :");
            if(FirstNumber.HasValue)
                Console.WriteLine(FirstNumber * FirstNumber);
            else
                Console.WriteLine("No Output");

            Console.Write("Second Number :");
            if (SecondNumber.HasValue)
                Console.WriteLine(SecondNumber * SecondNumber);
            else
                Console.WriteLine("No Output");

            Console.ReadLine();
        }
    }
}
