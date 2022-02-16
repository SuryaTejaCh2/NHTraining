using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheMatics;

namespace ConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n;
            Algebra al = new Algebra();

            Console.Write("Enter Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(al.Factorial(n));

            Console.ReadLine();
        }
    }
}
