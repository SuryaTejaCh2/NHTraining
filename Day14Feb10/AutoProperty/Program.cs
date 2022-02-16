using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Property
* *********************************************************************/

namespace AutoProperty
{
    class CalculateSpeed
    {
        private int time;
        private int distance;

        //Normal Properties
        public int Time { set { time = value; } }
        public int Distance { set { distance = value; } }
        public int Speed { get { return distance / time; } }
        //Auto - Implemented Properties
        public int Velocity { get { return distance / time; } set {} }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateSpeed calc = new CalculateSpeed();
            calc.Time = 20;
            calc.Distance = 60;

            Console.WriteLine($"Speed is {calc.Speed}");

            Console.ReadLine();
        }
    }
}
