using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Declare a 2-D array of size (2,2) and read values from user and print the array values.
* *********************************************************************/

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] data = new int[2, 2];

            //User input
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($"Enter array number at [{i}, {j}]: ");
                    data[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Print
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write($"{data[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
