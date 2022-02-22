using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**********************************************************************
* Author: Surya Teja
* Purpose: Data Access Layer Library
* *********************************************************************/

namespace DataAccessLayerLibrary
{
    public static class DAL
    {
        public static string filePath = "S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Day22Feb22\\EmployeeDetails.txt";
        /// <summary>
        /// Add Employee Details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployeeDetails(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                string empDetails = string.Concat(empId, ", ", empName, ", ", empSalary, ", ", empAge);
                File.AppendAllText(filePath, empDetails + Environment.NewLine);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Search Employee Details By Id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public static List<string> SearchEmployeeDetailsById(int empId)
        {
            var empData = File.ReadAllLines(filePath);
            List<string> found = new List<string>(); 
            foreach (string emp in empData)
            {
                var empDetails = emp.Split(',');
                if (Convert.ToInt32(empDetails[0]) == empId)
                {
                    found.Add(emp);
                    break;
                }
            }
            return found;
        }
        /// <summary>
        /// Search Employee Details By Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> SearchEmployeeDetailsByName(string name)
        {
            var empData = File.ReadAllLines(filePath);
            List<string> found = new List<string>();
            foreach (string emp in empData)
            {
                var empDetails = emp.Split(',');
                if ((empDetails[1].Contains(name)))
                {
                    found.Add(emp);
                }
            }
            return found;
        }
        /// <summary>
        /// Display Employee Details
        /// </summary>
        /// <returns></returns>
        public static string[] DisplayEmployeeDetails()
        {
            var empData = File.ReadAllLines(filePath);
            return empData;
        }
    }
}
