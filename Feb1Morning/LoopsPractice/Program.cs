using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: Create list of Customer and Product Arrays and practice a.
                a.	For
                b.	Foreach
                c.	lambda expression
* *********************************************************************/

namespace LoopsPractice
{
    class Customer
    {
        public int customerId;
        public string customerName;
        public string customerEmail;
    }

    class Product
    {
        public string productName;
        public int productPrice;
        public string productBrand;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] cm = new Customer[]
            {
                new Customer(){ customerId = 1, customerName = "Surya", customerEmail = "Surya@gmail"},
                new Customer(){ customerId = 2, customerName = "Bhanu", customerEmail = "Bhanu@gmail"},
                new Customer(){ customerId = 3, customerName = "Prudhvi", customerEmail = "Prudhvi@gmail"},
                new Customer(){ customerId = 4, customerName = "Ram Charan", customerEmail = "RamCharan@gmail"},
                new Customer(){ customerId = 5, customerName = "Joe", customerEmail = "Joe@gmail"}
            };

            Product[] pm = new Product[]
            {
                new Product(){ productName = "Shoes", productPrice = 5000, productBrand = "Nike"},
                new Product(){ productName = "Mobile", productPrice = 50000, productBrand = "Samsung"},
                new Product(){ productName = "Laptop", productPrice = 100000, productBrand = "Dell"},
                new Product(){ productName = "Watch", productPrice = 15000, productBrand = "GShock"},
                new Product(){ productName = "Cap", productPrice = 2000, productBrand = "Adidas"}
            };


            Console.WriteLine("\n----------ForLoop-----Customer----------");
            for (int i = 0; i < cm.Length; i++)
                Console.WriteLine($"\nCustomer Id: {cm[i].customerId}, Customer Name: {cm[i].customerName}, Customer Email: {cm[i].customerEmail}.");

            Console.WriteLine("\n----------ForLoop-----Product----------");
            for (int i = 0; i < pm.Length; i++)
                Console.WriteLine($"\nProduct Name: {pm[i].productName}, Product Price: {pm[i].productPrice}, Product Brand: {pm[i].productBrand}.");

            Console.WriteLine("\n----------ForEachLoop-----Customer----------");
            foreach (var c in cm)
                Console.WriteLine($"\nCustomer Id: {c.customerId}, Customer Name: {c.customerName}, Customer Email: {c.customerEmail}.");

            Console.WriteLine("\n----------ForEachLoop-----Product----------");
            foreach (var p in pm)
                Console.WriteLine($"\nProduct Name: {p.productName}, Product Price: {p.productPrice}, Product Brand: {p.productBrand}.");

            Console.WriteLine("\n----------LambdaExpression-----Customer----------");
            cm.ToList().ForEach(c => Console.WriteLine($"\nCustomer Id: {c.customerId}, Customer Name: {c.customerName}, Customer Email: {c.customerEmail}."));

            Console.WriteLine("\n----------LambdaExpression-----Product----------");
            pm.ToList().ForEach(p => Console.WriteLine($"\nProduct Name: {p.productName}, Product Price: {p.productPrice}, Product Brand: {p.productBrand}."));

            Console.ReadLine();

        }
    }
}