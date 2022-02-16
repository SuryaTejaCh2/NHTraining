using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Physics Library
* *********************************************************************/

namespace Surya
{
    public class Physics
    {
        public int d;
        public int t;
        /// <summary>
        /// User Input
        /// </summary>
        public void ReadData()
        {
            Console.Write("Enter Distance: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Time: ");
            t = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Caliculate Speed
        /// </summary>
        /// <returns>Return Speed Value</returns>
        public int Speed()
        {
            int s = 0;
            try
            {
                s = d / t;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Time cannot be zero");
            }
            return s;
        }
    }
}
