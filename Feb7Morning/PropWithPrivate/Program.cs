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
        public int Id { get { return Id; } set { Id = value; } }
        public string Name { get { return Name; } set { Name = value; } }
        public string Designation { get { return Designation; } set { Designation = "S"; } }
        public int Salary 
        { 
            get { return Salary; } set { Salary = value; } }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.ReadLine();
        }
    }
}
