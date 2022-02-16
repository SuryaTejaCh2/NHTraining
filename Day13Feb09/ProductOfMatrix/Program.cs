using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Product Of Matrix
* *********************************************************************/

namespace ProductOfMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f1, f2, s1, s2;

            //Read Data
            Console.Write("Enter Row size of First matrix: ");
            f1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Colomn size of First matrix: ");
            f2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Row size of Second matrix: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Colomn size of Second matrix: ");
            s2 = Convert.ToInt32(Console.ReadLine());

            //Array
            int[,] first = new int[f1, f2];
            int[,] second = new int[s1, s2];
            int[,] product = new int[f1, s2];
            
            //User input for first matrix
            for (int i = 0; i < f1; i++)
            {
                for (int j = 0; j < f2; j++)
                {
                    Console.Write($"Enter array number at [{i}, {j}]: ");
                    first[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Print for first matrix
            for (int i = 0; i < f1; i++)
            {
                for (int j = 0; j < f2; j++)
                {
                    Console.Write($"{first[i, j]} ");
                }
                Console.WriteLine();
            }

            //User input for second matrix
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    Console.Write($"Enter array number at [{i}, {j}]: ");
                    second[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Print for second matrix
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    Console.Write($"{second[i, j]} ");
                }
                Console.WriteLine();
            }

            //Logic for mutlipcation table
            if(f2 == s1)
            {
                for(int i = 0; i < f1; i++)
                {
                    for(int j = 0; j < s2; j++)
                    {
                        product[i, j] = 0;
                        for(int k = 0; k < f2; k++)
                        {
                            product[i, j] += first[i, k] * second[k, j];
                        }
                    }
                }

                //Print Mul Table
                for(int i = 0; i < f1; i++)
                {
                    for(int j = 0; j < s2; j++)
                    {
                        Console.Write($"{product[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
