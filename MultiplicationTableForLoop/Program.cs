using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableForLoop
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
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(input+"x"+i+"="+input*i);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}x{1}={2}",input,i,input*i);
            }

            Console.ReadLine();
        }
    }
}
