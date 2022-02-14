using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Hello World OOPS
* *********************************************************************/

namespace HelloWorldOOPS
{
    class HelloWorld
    {
        /// <summary>
        /// Print Hello World
        /// </summary>
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hw = new HelloWorld();
            hw.PrintHelloWorld();

            Console.ReadLine();
        }
    }
}
