using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Car Design
* *********************************************************************/

namespace CarDesign
{
    abstract class Car
    {
        public bool Engine()
        {
            return true;
        }
        public abstract double Length();
        public abstract double Width();
        public abstract int MaxSpeed();
    }

    class Audi : Car
    {
        public override double Length()
        {
            return 17.4;
        }
        public override double Width()
        {
            return 6.38;
        }
        public override int MaxSpeed()
        {
            return 250;
        }
    }

    class BMW : Car
    {
        public override double Length()
        {
            return 17.12;
        }
        public override double Width()
        {
            return 6.24;
        }
        public override int MaxSpeed()
        {
            return 250;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Completed");

            Console.ReadLine();
        }
    }
}
