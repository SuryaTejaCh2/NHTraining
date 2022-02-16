using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Property
* *********************************************************************/

namespace Prop
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Designation { set { designation = value; } }
        public int Salary 
        { 
            get 
            {
                salary = (designation == "S") ? 30000 : 60000;
                return salary;
            }
            set { salary = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter Manager - M or Employee - S: ");
            emp.Designation = Console.ReadLine();
            Console.WriteLine($"Salary is {emp.Salary}");

            Console.ReadLine();
        }
    }
}
