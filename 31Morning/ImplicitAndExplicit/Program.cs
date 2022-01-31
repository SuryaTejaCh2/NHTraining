using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitAndExplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit type casting
            short shortValue = 10;
            int intValue = shortValue;
            Console.WriteLine($"Short Value is {shortValue} and Integer Value is {intValue}.");

            //Explicit type casting
            double doubleValue = 5.7;
            float floatValue = Convert.ToSingle(doubleValue);
            Console.WriteLine($"Double Value is {doubleValue} and Float Value is {floatValue}.");

            Console.ReadLine();
        }
    }
}
