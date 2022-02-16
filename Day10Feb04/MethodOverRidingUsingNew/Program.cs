using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRidingUsingNew
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
        public void PrintGM()
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
        public new void PrintGM()
        {
            Console.WriteLine("Subhodhayam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Telugu t = new Telugu();
            t.PrintHi();
            t.PrintGM();

            Console.ReadLine();
        }
    }
}
