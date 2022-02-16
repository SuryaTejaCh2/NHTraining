using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: PropertyOnly
* *********************************************************************/

namespace PropWithPrivate
{
    class Employee
    {
        string designation;
        public int Id { get { return Id; } set { Id = value; } }
        public string Name { get { return Name; } set { Name = value; } }
        public string Designation { set { designation = value; } }
        public int Salary 
        { 
            get 
            { 
                return (designation == "S") ? 30000 : 60000; 
            } set { Salary = value; } }
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
