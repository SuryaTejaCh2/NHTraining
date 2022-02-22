using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerLibrary;

/**********************************************************************
* Author: Surya Teja
* Purpose: Business Logic Layer Library
* *********************************************************************/

namespace BusinessLogicLayerLibrary
{

    public class BLL
    {
        /// <summary>
        /// Add Employee Details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployeeDetails( int empId, string empName, int empSalary, int empAge)
        {
            int id = empId;
            string name = empName;
            int salary = empSalary;
            int age = empAge;
                if(empId < 0)
                {
                    
                }
                if(empName.Length <= 2)
                {
                    Console.WriteLine("Enter Full Name");
                }
            var empDetailsAdd = DAL.AddEmployeeDetails(empId, empName, empSalary, empAge);
            return empDetailsAdd;
        }
        /// <summary>
        /// Search Employee Details By Id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public static List<string> SearchEmployeeDetailsById(int empId)
        {
            var empDetailsId = DAL.SearchEmployeeDetailsById(empId);
            return empDetailsId;
        }
        /// <summary>
        /// Search Employee Details By Name
        /// </summary>
        /// <param name="empName"></param>
        /// <returns></returns>
        public static List<string> SearchEmployeeDetailsByName(string empName)
        {
            var empDetailsName = DAL.SearchEmployeeDetailsByName(empName);
            return empDetailsName;
        }
        /// <summary>
        /// Display Employee Details
        /// </summary>
        /// <returns></returns>
        public static string[] DisplayEmployeeDetails()
        {
            var empDetails = DAL.DisplayEmployeeDetails();
            return empDetails;
        }
    }
}
