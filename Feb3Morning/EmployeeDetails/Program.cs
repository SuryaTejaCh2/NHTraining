using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Create an employee class with below variables id, name, salary, company write methods to read data and print data.
* *********************************************************************/

namespace EmployeeDetails
{
    class Employee
    {
        private int id;
        private string name;
        private int salary;

        public static string company = "NationsBenefits";

        /// <summary>
        /// Get input employee details 
        /// </summary>

        public void ReadData()
        {
            Console.Write("Enter Emloyee Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Emloyee Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Emloyee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Print the employee details
        /// </summary>

        public void Printdata()
        {
            Console.WriteLine($"\nEmployee Id {id}, Employee Name {name}, Employee Salary {salary}, Company name {company}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.ReadData();
            emp.Printdata();

            Console.ReadLine();
        }
    }
}
