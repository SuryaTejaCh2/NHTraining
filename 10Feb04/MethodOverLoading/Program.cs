using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Write sample code for method overloading
* *********************************************************************/

namespace MethodOverLoading
{
    /// <summary>
    /// Method Over Loading
    /// </summary>
    class Operators
    {
        /// <summary>
        /// Method for adding Two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Method for adding Three numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();
            Console.WriteLine(op.Add(2,3));
            Console.WriteLine(op.Add(2, 3, 5));

            Console.ReadLine();
        }
    }
}