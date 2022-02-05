using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Create Employee class with 3 public variables. Create Employee object and initialize with values while creating object and print the values.
* *********************************************************************/


namespace EmployeeDetails
{
    class Employee
    {
        public int id;
        public string name;
        public int age;
        public int salary;

        public void ReadData()
        {
            Console.Write("Enter Employee Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Employee Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine($"\nEmployee Id: {id}, Employee Name: {name}, Employee Age: {age}, Employee Salary: {salary}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee() { id = 2, name = "Surya", age = 22, salary = 2000 };
            Console.WriteLine($"Employee Id: {e.id}, Employee Name: {e.name}, Employee Age: {e.age}, Employee Salary: {e.salary}.");

            Console.ReadLine();
        }
    }
}
