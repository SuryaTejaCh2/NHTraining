using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheMatics
{
    public class Mathematics
    {
        public int input;
        /// <summary>
        /// Read data from user
        /// </summary>
        public void ReadNumber()
        {
            Console.Write("Enter Number: ");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Factorial logic
        /// </summary>
        /// <returns>Factorial value</returns>
        public int GetFact()
        {
            int fact = 1;

            for (int i = 2; i <= input; i++)
                fact = fact * i;
            return fact;
        }
    }
}
