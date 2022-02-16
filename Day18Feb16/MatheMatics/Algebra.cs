using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheMatics
{
    public class Algebra
    {
        public int Factorial(int n)
        {
            int fact = 1;

            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                for (int i = 1; i <= n; i++)
                    fact = fact * i;
                return fact;
            }
        }
        public int Palindrome(int num)
        {
            int rem, temp, sum = 0;

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
            return temp;
        }
    }
}
