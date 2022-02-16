using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Declare TWO 2-D arrays of size (2,2) and read values from user and print the sum of the two matrices.
* *********************************************************************/

namespace SumOfTwoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data1 = new int[2, 2];
            int[,] data2 = new int[2, 2];
            int[,] data3 = new int[2, 2];

            //User input for data1
            for (int i = 0; i < data1.GetLength(0); i++)
            {
                for (int j = 0; j < data1.GetLength(1); j++)
                {
                    Console.Write($"Enter array number at [{i}, {j}]: ");
                    data1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Print for data1
            for (int i = 0; i < data1.GetLength(0); i++)
            {
                for (int j = 0; j < data1.GetLength(1); j++)
                {
                    Console.Write($"{data1[i, j]} ");
                }
                Console.WriteLine();
            }


            //User input for data2
            for (int i = 0; i < data2.GetLength(0); i++)
            {
                for (int j = 0; j < data2.GetLength(1); j++)
                {
                    Console.Write($"Enter array number at [{i}, {j}]: ");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Print for data2
            for (int i = 0; i < data2.GetLength(0); i++)
            {
                for (int j = 0; j < data2.GetLength(1); j++)
                {
                    Console.Write($"{data2[i, j]} ");
                }
                Console.WriteLine();
            }

            //Logic for sum of two matrices
            for (int i = 0; i < data3.GetLength(0); i++)
            {
                for (int j = 0; j < data3.GetLength(1); j++)
                {
                        data3[i, j] = data1[i, j] + data2[i, j];
                }
            }

            //Print sum of two matrices
            Console.WriteLine("Sum of two Matrices are: ");
            for (int i = 0; i < data3.GetLength(0); i++)
            {
                for (int j = 0; j < data3.GetLength(1); j++)
                {
                    Console.Write($"{data3[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}