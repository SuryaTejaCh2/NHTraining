using System;

namespace TypesOfInheritance
{
    /// <summary>
    /// MultiLevel Inheritance
    /// </summary>
    class Company
    {
        /// <summary>
        /// Company Name
        /// </summary>
        public void CompanyName()
        {
            Console.WriteLine("Nations Benefits");
        }
        /// <summary>
        /// Company City
        /// </summary>
        public void CompanyCity()
        {
            Console.WriteLine("Hyderabad");
        }
    }
    /// <summary>
    /// Employee class inherit Company class
    /// </summary>
    class Employee : Company
    {
        private int id;
        private string name;
        /// <summary>
        /// Read Input from user
        /// </summary>
        public void ReadEmployee()
        {
            Console.Write("Enter employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee Name: ");
            name = Console.ReadLine();
        }
        /// <summary>
        /// Employee Id
        /// </summary>
        public void EmployeeId()
        {
            Console.WriteLine($"Employee Id is {id}");
        }
        /// <summary>
        /// Employee Name
        /// </summary>
        public void EmployeeName()
        {
            Console.WriteLine($"Employee Name is {name}");
        }
    }
    /// <summary>
    /// EmployeeDetails class inherit Employee class
    /// </summary>
    class EmployeeDetails : Employee
    {
        private int number;
        private string designation;
        /// <summary>
        /// Read Input from user
        /// </summary>
        public void ReadEmployeeD()
        {
            Console.Write("Enter employee Number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee Designation: ");
            designation = Console.ReadLine();
        }
        /// <summary>
        /// Employee Number
        /// </summary>
        public void EmployeeNumber()
        {
            Console.WriteLine($"Employee Number is {number}");
        }
        /// <summary>
        /// Employee Designation
        /// </summary>
        public void EmployeeDesignation()
        {
            Console.WriteLine($"Employee Designation is {designation}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            EmployeeDetails empD = new EmployeeDetails();

            emp.ReadEmployee();
            empD.ReadEmployeeD();

            emp.EmployeeId();
            emp.EmployeeName();
            emp.CompanyName();
            emp.CompanyCity();

            empD.EmployeeNumber();
            empD.EmployeeDesignation();

            Console.ReadLine();
        }
    }
}