using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayerLibrary;

/**********************************************************************
* Author: Surya Teja
* Purpose: Client Application
* *********************************************************************/

namespace ClientApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            string d;
            do
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("1. Add Employee Details");
                Console.WriteLine("2. Search Employee Details By Id");
                Console.WriteLine("3. Search Employee Details By Name");
                Console.WriteLine("4. Display All Employee Details");
                Console.Write("\nEnter your Choice: ");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeeById();
                        break;
                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayEmployee();
                        break;
                    default:
                        Console.WriteLine("Enter valid option");
                        break;
                }
                Console.Write("\nDo you want to continue(y/n): \n");
                d = Console.ReadLine();
            }
            while (d.Equals("y"));
        }
        /// <summary>
        /// Add Employee
        /// </summary>
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;

            Console.Write("\nEnter employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee Name: ");
            name = Console.ReadLine();
            Console.Write("Enter employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            var empDetails = BLL.AddEmployeeDetails(id, name, salary, age);
            
            if(empDetails)
                Console.WriteLine("Employee Details Added Successfully");
            else
                Console.WriteLine("Error Occured");
        }
        /// <summary>
        /// Search mployee By Id
        /// </summary>
        public static void SearchEmployeeById()
        {
            int id;

            Console.Write("Enter employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            var empDetails = BLL.SearchEmployeeDetailsById(id);

            if (empDetails.Count == 0)
                Console.WriteLine($"No Employee exists on this {id}");
            else
            {
                empDetails.ForEach(e => Console.WriteLine(e));
            }
        }
        /// <summary>
        /// Search mployee By Name
        /// </summary>
        public static void SearchEmployeeByName()
        {
            string name;

            Console.Write("Enter employee Name: ");
            name = Console.ReadLine();

            var empDetails = BLL.SearchEmployeeDetailsByName(name);

            if (empDetails.Count == 0)
                Console.WriteLine($"No Employee exists on this {name}");
            else
            {
                empDetails.ForEach(e => Console.WriteLine(e));
            }
        }
        /// <summary>
        /// Diaplay Employee
        /// </summary>
        public static void DisplayEmployee()
        {
            var empDetails = BLL.DisplayEmployeeDetails();

            foreach(var emp in empDetails)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
