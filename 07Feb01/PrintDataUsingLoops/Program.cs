using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Create Employee class and create employees array object and initialize with 5 employees and print who is getting salary >=5000 using
               a. for loop
               b. foreach loop
               c. lambda expressions
* *********************************************************************/

namespace PrintDataUsingLoops
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[]
            {
                new Employee() { id = 1, name = "Surya", salary = 10000 },
                new Employee() { id = 2, name = "Bhanu", salary = 8000 },
                new Employee() { id = 3, name = "Prudhvi", salary = 6000 },
                new Employee() { id = 4, name = "Ram Charan", salary = 4000 },
                new Employee() { id = 5, name = "Joe", salary = 2000 }
            };

            Console.WriteLine("----------ForLoop----------");
            for (int i = 0; i < emp.Length; i++)
            {
                if(emp[i].salary >= 5000)
                    Console.WriteLine($"\nEmployee id: {emp[i].id}, Employee Name: {emp[i].name}, Employee Salary: {emp[i].salary}.");
            }

            Console.WriteLine("\n----------ForEachLoop----------");
            foreach (Employee e in emp)
            {
                if(e.salary >= 5000)
                    Console.WriteLine($"\nEmployee id: {e.id}, Employee Name: {e.name}, Employee Salary: {e.salary}.");
            }

            Console.WriteLine("\n----------LambdaExpression----------");
            emp.ToList().Where(e => e.salary >= 5000).ToList().ForEach(e => Console.WriteLine($"\nEmployee id: {e.id}, Employee Name: {e.name}, Employee Salary: {e.salary}."));


            Console.ReadLine();
        }
    }
}
