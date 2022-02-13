using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPriceGreater500
{

    /**********************************************************************
    * Author: Surya Teja
    * Purpose: Create a class Product and add variables id, name, price, brand print product (name and brand) whose price is more than 500 using.(for, foreach loop, lambda, linq query)
    * *********************************************************************/


    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> prodData = new List<Product>()
            {
                new Product() { id = 1, name = "Shoes", price = 1500, brand = "Nike"},
                new Product() { id = 2, name = "Cap", price = 1200, brand = "Adidas"},
                new Product() { id = 3, name = "Pen", price = 450, brand = "Parker"},
                new Product() { id = 4, name = "Book", price = 100, brand = "Classmate"},
                new Product() { id = 5, name = "Laptop", price = 50000, brand = "Dell"}
            };

            //For Loop
            Console.WriteLine("********************For Loop*******************\n");
            
            for (int i = 0; i < prodData.Count; i++)
            {
                if (prodData[i].price >= 500)
                    Console.WriteLine($"Name is {prodData[i].name} and Brand is {prodData[i].brand}.");
            }

            //For Each Loop
            Console.WriteLine("\n*****************ForEach Loop******************\n");

            foreach (Product prod in prodData)
            {
                if(prod.price >= 500)
                    Console.WriteLine($"Name is {prod.name} and Brand is {prod.brand}.");
            }
            
            //Lambda Expression
            Console.WriteLine("\n***************Lambda Expression***************\n");

            prodData.Where(p => p.price >= 500).ToList().ForEach(p => Console.WriteLine($"Name is {p.name} and Brand is {p.brand}."));

            //LINQ Query
            Console.WriteLine("\n*******************LINQ Query******************\n");

            var result = from prod in prodData
                         where prod.price >= 500
                         select prod;
            result.ToList().ForEach(p => Console.WriteLine($"Name is {p.name} and Brand is {p.brand}."));

            Console.ReadLine();
        }
    }
}
