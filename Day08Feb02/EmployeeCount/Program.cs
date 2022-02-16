using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCount
{

    /**********************************************************************
    * Author: Surya Teja
    * Purpose: Create a Department class and add variables id, name, empcount write code to print id, name of departments whose empcount is greater than 50.(for, foreach, lambda, linq query)
    * *********************************************************************/

    class Department
    {
        public int id;
        public string name;
        public int empCount;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> deptData= new List<Department>()
            {
                new Department(){ id = 1, name ="CSE", empCount = 80},
                new Department(){ id = 2, name ="Mech", empCount = 75},
                new Department(){ id = 3, name ="EEE", empCount = 60},
                new Department(){ id = 4, name ="Civil", empCount = 20},
                new Department(){ id = 5, name ="ECE", empCount = 25}
            };

            //For Loop
            Console.WriteLine("********************For Loop*******************\n");
            
            for (int i = 0; i < deptData.Count; i++)
            {
                if (deptData[i].empCount >= 50)
                    Console.WriteLine($"Department Id is: {deptData[i].id} and Department Name is: {deptData[i].name}.");
            }

            //For Each Loop
            Console.WriteLine("\n*****************ForEach Loop******************\n");

            foreach (Department dept in deptData)
            {
                if (dept.empCount >= 50)
                    Console.WriteLine($"Department Id is: {dept.id} and Department Name is: {dept.name}.");
            }

            //Lambda Expression
            Console.WriteLine("\n***************Lambda Expression***************\n");

            deptData.Where(d => d.empCount >= 50).ToList().ForEach(d => Console.WriteLine($"Department Id is: {d.id} and Department Name is: {d.name}."));
            
            //LINQ Query
            Console.WriteLine("\n*******************LINQ Query******************\n");

            var result = from dept in deptData
                         where dept.empCount >= 50
                         select dept;
            result.ToList().ForEach(d => Console.WriteLine($"Department Id is: {d.id} and Department Name is: {d.name}."));

            Console.ReadLine();
        }
    }
}
