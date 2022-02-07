using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Salary Process
* *********************************************************************/

namespace SalaryProcess
{
    abstract class Salary
    {
        public int GetPF(int basic)
        {
            return 12 * basic / 100;
        }
        public int GetHRA(int basic)
        {
            return 40 * basic / 100;
        }

        public abstract int GetCA();

        public abstract int GetSA();
    }

    class Microsoft : Salary
    {
        public override int GetCA()
        {
            return 6000;
        }

        public override int GetSA()
        {
            return 5000;
        }
    }

    class Google : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }

        public override int GetSA()
        {
            return 9000;
        }
    }

    class Tesla : Salary
    {
        public override int GetCA()
        {
            return 8000;
        }

        public override int GetSA()
        {
            return 6000;
        }
    }

    class Facebook : Salary
    {
        public override int GetCA()
        {
            return 7000;
        }

        public override int GetSA()
        {
            return 5000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Completed");

            Console.ReadLine();
        }
    }
}
