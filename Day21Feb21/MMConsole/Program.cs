using MMConsole.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MMWebSoapClient con = new MMWebSoapClient();
            Console.WriteLine($"Factorial is {con.Factorial(5)}");
            Console.WriteLine($"Addition is {con.Add(7, 5)}");
            Console.WriteLine($"Subraction is {con.Sub(7, 5)}");
            Console.WriteLine($"Multiplaction is {con.Mul(7, 5)}");
            Console.WriteLine($"Divison is {con.Div(7, 5)}");

            Console.ReadLine();
        }
    }
}
