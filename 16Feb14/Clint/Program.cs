using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surya;
using Operations;

/**********************************************************************
* Author: Surya Teja
* Purpose: Clint
* *********************************************************************/

namespace Clint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Opp1 op1 = new Opp1();
            Opp2 op2 = new Opp2();

            Console.WriteLine("\n*****Mathematics*****\n");
            m.ReadNumber();
            Console.WriteLine($"Factorial of {m.input} is {m.GetFact()}");

            Console.WriteLine("\n*****Operations*****\n");
            Console.WriteLine($"Addition of A and B is {op1.Add(20, 10)}");
            Console.WriteLine($"Subraction of A and B is {op1.Sub(20, 10)}");
            Console.WriteLine($"Multiplation of A and B is {op2.Mul(20, 10)}");
            Console.WriteLine($"Divison of A and B is {op2.Div(20, 10)}");

            Console.ReadLine();
        }
    }
}
