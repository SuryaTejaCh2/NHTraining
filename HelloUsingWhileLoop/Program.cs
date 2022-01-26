using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUsingWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize
            int i = 1;

            //Logic and Output
            while (i <= 5)
            {
                Console.WriteLine("Hello");
                i++;
            }

            Console.ReadLine();
        }
    }
}
