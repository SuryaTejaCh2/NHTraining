using System;

/**********************************************************************
* Author: Surya Teja
* Purpose: Write C# code to illustrate the usage of delegates.
* *********************************************************************/

namespace DelegateE
{
    public delegate void Call(int a, int b);
    class Dele
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Call c = new Call(Dele.Add);
            c += Dele.Sub;
            c += Dele.Mul;
            c += Dele.Div;

            c(20, 10);
            c(70, 50);

            Console.ReadLine();
        }
    }
}
