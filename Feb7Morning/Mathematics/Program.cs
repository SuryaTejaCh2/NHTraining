using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Static Method
* *********************************************************************/

namespace Mathematics
{
    class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Addition of two numbers is: {Maths.Add(5,7)}");
            Console.WriteLine($"Subraction of two numbers is: {Maths.Sub(30,25)}");
            Console.WriteLine($"Multiplation of two numbers is: {Maths.Mul(20,5)}");
            Console.WriteLine($"Divison of two numbers is: {Maths.Div(21,3)}");

            Console.ReadLine();
        }
    }
}
