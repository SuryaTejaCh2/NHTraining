using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Research and write sample code for method overriding using virual, override keyword.
* *********************************************************************/

namespace MethodOverRidingUsingVirtualAndOverride
{
    internal class Program
    {
        /// <summary>
        /// Creating class English
        /// </summary>
        class English
        {
            /// <summary>
            /// Print Hi Message
            /// </summary>
            public void PrintHi()
            {
                Console.WriteLine("Hi");
            }
            /// <summary>
            /// Print Good Morning Message
            /// </summary>
            public virtual void PrintGM()
            {
                Console.WriteLine("Good Morning");
            }
        }
        /// <summary>
        /// Creating class Telugu
        /// </summary>
        class Telugu : English
        {
            /// <summary>
            /// Print Subhodhayam Message
            /// </summary>
            public override void PrintGM()
            {
                Console.WriteLine("Subhodhayam");
            }
        }
        static void Main(string[] args)
        {
            Telugu t = new Telugu();
            t.PrintHi();
            t.PrintGM();

            Console.ReadLine();
        }
    }
}
