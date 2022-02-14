using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Palindrome
* *********************************************************************/

namespace PalindromeOOPS
{
    class Palindrome
    {
        int num, rem, temp, sum = 0;
        /// <summary>
        /// Read User Input
        /// </summary>
        public void ReadNumber()
        {
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Print Palindrome or not
        /// </summary>
        public void PrintPalindrome()
        {
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (temp == sum)
                Console.Write($"{temp} is Palindrome.");
            else
                Console.Write($"{temp} is not Palindrome");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadNumber();
            p.PrintPalindrome();

            Console.ReadLine();
        }
    }
}
