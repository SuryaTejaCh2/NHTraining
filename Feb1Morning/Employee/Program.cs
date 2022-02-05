using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Create Employee class with three variables and two methods ReadEmployee and PrintEmployee and create an object and call methods.
* *********************************************************************/

namespace Employee
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void ReadData()
        {
            Console.Write("Enter Employee Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine($"\nEmployee Id: {id}, Employee Name: {name}, Employee Salary: {salary}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.ReadData();
            emp.PrintData();

            Console.ReadLine();
        }
    }
}
