using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surya;

namespace Subject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chemistry c = new Chemistry();
            Mathematics m = new Mathematics();
            Physics p = new Physics();

            Console.WriteLine("\n*****Chemistry*****\n");
            c.ReadData();
            c.Output();

            Console.WriteLine("\n*****Mathematics*****\n");
            m.ReadNumber();
            Console.WriteLine($"Factorial of {m.input} is {m.GetFact()}");

            Console.WriteLine("\n*****Physics*****\n");
            p.ReadData();
            Console.WriteLine($"Speed is { p.Speed()}");

            Console.ReadLine();
        }
    }
}
