using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Table
* *********************************************************************/

namespace TableOOPS
{
    class Table
    {
        int input;
        /// <summary>
        /// Read User Input
        /// </summary>
        public void ReadData()
        {
            Console.Write("Enter Number: ");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Print Table
        /// </summary>
        public void PrintTable()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{input} * {i} = {input * i}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Table t = new Table();
            t.ReadData();
            t.PrintTable();

            Console.ReadLine();
        }
    }
}
