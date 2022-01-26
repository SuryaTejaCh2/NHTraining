using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initilize
            int input;

            //User Input
            Console.Write("Enter any number: ");
            input = Convert.ToInt32(Console.ReadLine());

            //Logic and Output

            int i = 1;

            while(i <= 10)
            {
                Console.WriteLine(input + "x" + i + "=" + input * i);
                i++;
            }
            
            Console.WriteLine();
            Console.WriteLine();

            int j = 1;

            while (j <= 10)
            {
                Console.WriteLine("{0}x{1}={2}", input, j, input * j);
                j++;
            }
            
            Console.ReadLine();
        }
    }
}
