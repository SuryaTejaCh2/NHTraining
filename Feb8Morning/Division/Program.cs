using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Divison of two numbers using try, catch and finally block
* *********************************************************************/

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, div;

            try
            {
                Console.Write("Enter First Number:");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number:");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                div = firstNumber / secondNumber;

                Console.WriteLine($"Divison is :{div}");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Enter number range from {int.MinValue} to {int.MaxValue}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Enter second number as other than zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers");
            }
            catch (Exception)
            {
                Console.WriteLine("Please contact Office");
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\nDesigned by Surya");
                Console.ReadLine();
            }
        }
    }
}
