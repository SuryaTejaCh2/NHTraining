using System;

/**********************************************************************
* Author: Surya Teja
* Purpose: Out and Ref.
* *********************************************************************/

namespace RefAndOut
{
    class RefOut
    {
        public void update(out int a)
        {
            a = 10;
        }
        public void change(ref int d)
        {
            d = 11;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RefOut ro = new RefOut();
            int b;
            int c = 9;
            
            ro.update(out b);
            ro.change(ref c);
            Console.WriteLine($"Updated value is: {b}");
            Console.WriteLine($"Changed value is: {c}");


            Console.ReadLine();
        }
    }
}
