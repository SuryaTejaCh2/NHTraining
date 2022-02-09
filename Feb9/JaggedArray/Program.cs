using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Jagged Array
* *********************************************************************/

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];

            names[0] = new char[] { 'N','I','K','E' };
            names[1] = new char[] { 'A','D','I','D','A','S' };
            names[2] = new char[] { 'W','O','O','D','L','A','N','D' };

            // Display the array elements.
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name at position {i} is ");
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
