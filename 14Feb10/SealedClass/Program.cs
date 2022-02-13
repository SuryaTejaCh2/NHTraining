using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Sealed Class
* *********************************************************************/

namespace SealedClass
{
    sealed class Customer
    {
        private string userName;
        private string password;

        public void ReadData()
        {
            Console.Write("Enter User Name: ");
            userName = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine($"Username is {userName}.");
            Console.WriteLine($"Password is {password}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cu = new Customer();
            cu.ReadData();
            cu.PrintData();

            Console.ReadLine();
        }
    }
}
