using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: 4.	Create below classes:
                •	Customer
                •	Product
                •	Seller
                •	Department
* *********************************************************************/

namespace Shopping
{
    class Customer
    {
        private int customerId;
        private string customerName;
        private string customerEmail;

        public void ReadCustomerData()
        {
            Console.Write("Enter Customer Id: ");
            customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            customerName = Console.ReadLine();
            Console.Write("Enter Customer Email: ");
            customerEmail = Console.ReadLine();
        }

        public void PrintCustomerData()
        {
            Console.WriteLine($"\nCustomer Id: {customerId}, Customer Name: {customerName}, Customer Email: {customerEmail}.");
        }
    }

    class Product
    {
        private string productName;
        private int productPrice;
        private string productType;

        public void ReadProductData()
        {
            Console.Write("Enter Product Name: ");
            productName = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            productPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Type: ");
            productType = Console.ReadLine();
        }

        public void PrintProductData()
        {
            Console.WriteLine($"\nProduct Name: {productName}, Product Price: {productPrice}, Product Type: {productType}.");
        }
    }

    class Seller
    {
        private int sellerId;
        private string sellerName;
        private string sellerAddress;

        public void ReadSellerData()
        {
            Console.Write("Enter Seller Id: ");
            sellerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Seller Name: ");
            sellerName = Console.ReadLine();
            Console.Write("Enter Seller Adderss: ");
            sellerAddress = Console.ReadLine();
        }

        public void PrintSellerData()
        {
            Console.WriteLine($"\nSeller Id: {sellerId}, Seller Name: {sellerName}, Seller Address: {sellerAddress}.");
        }
    }

    class Department
    {
        private int departmentId;
        private string departmentName;
        private string departmentType;

        public void ReadDepartmentData()
        {
            Console.Write("Enter Department Id: ");
            departmentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Department Name: ");
            departmentName = Console.ReadLine();
            Console.Write("Enter Department Type: ");
            departmentType = Console.ReadLine();
        }

        public void PrintDepartmentData()
        {
            Console.WriteLine($"\nDepartment Id: {departmentId}, Department Name: {departmentName}, Department Type: {departmentType}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cm = new Customer();
            Console.WriteLine("----------Customer Details----------");
            cm.ReadCustomerData();
            cm.PrintCustomerData();

            Product pd = new Product();
            Console.WriteLine("\n----------Product Details----------");
            pd.ReadProductData();
            pd.PrintProductData();

            Seller sl = new Seller();
            Console.WriteLine("\n----------Seller Details----------");
            sl.ReadSellerData();
            sl.PrintSellerData();

            Department dp = new Department();
            Console.WriteLine("\n----------Department Details----------");
            dp.ReadDepartmentData();
            dp.PrintDepartmentData();

            Console.ReadLine();
        }
    }
}
