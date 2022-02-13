using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintUsingClass
{
    /**********************************************************************
    * Author: Surya Teja
    * Purpose: Create a class Employee with three variables as discussed in the class and create a list of Employees.
    * *********************************************************************/


    class Employee
    {
        public int id;
        public string name;
        public float salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empData = new List<Employee>()
            {
                new Employee(){id = 1, name = "Surya", salary = 5000},
                new Employee(){id = 2, name = "Prudhvi", salary = 6000},
                new Employee(){id = 3, name = "Bhanu", salary = 7000},
                new Employee(){id = 4, name = "Charan", salary = 8000},
                new Employee(){id = 5, name = "Joe", salary = 9000}
            };

            //For Loop
            Console.WriteLine("********************For Loop*******************\n");
            for (int i = 0; i < empData.Count; i++)
                Console.WriteLine($"Employee Id is: {empData[i].id}, Employee Name is: {empData[i].name}, Employee Salary is: {empData[i].salary}.");

            //For Each Loop
            Console.WriteLine("\n*****************ForEach Loop******************\n");
            foreach (Employee emp in empData)
                Console.WriteLine($"Employee Id is: {emp.id}, Employee Name is: {emp.name}, Employee Salary is: {emp.salary}.");

            //Lambda Expression
            Console.WriteLine("\n***************Lambda Expression***************\n");
            empData.ForEach(e => Console.WriteLine($"Employee Id is: {e.id}, Employee Name is: {e.name}, Employee Salary is: {e.salary}."));
            
            //LINQ Query
            Console.WriteLine("\n*******************LINQ Query******************\n");
            var result = from emp in empData
                         select emp;
            result.ToList().ForEach(e => Console.WriteLine($"Employee Id is: {e.id}, Employee Name is: {e.name}, Employee Salary is: {e.salary}."));


            Console.ReadLine();
        }
    }
}
