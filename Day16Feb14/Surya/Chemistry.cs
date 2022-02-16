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
    public class Chemistry
    {
        public string water;
        public string acid;
        /// <summary>
        /// Read User Input
        /// </summary>
        public void ReadData()
        {
            Console.Write("Enter Water formula: ");
            water = Console.ReadLine();
            Console.Write("Enter Acid formula: ");
            acid = Console.ReadLine();
        }
        /// <summary>
        /// Print Output
        /// </summary>
        public void Output()
        {
            Console.WriteLine($"Water formula is {water}");
            Console.WriteLine($"Acid formula is {acid}");
        }
    }
}
