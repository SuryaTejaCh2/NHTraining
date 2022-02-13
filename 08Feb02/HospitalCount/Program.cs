using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCount
{

    /**********************************************************************
    * Author: Surya Teja
    * Purpose: Create your own class and variables and initialize with some values(for, foreach, lambda, linq query)
    * *********************************************************************/

    class Hospital
    {
        public int id;
        public string city;
        public int count;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hospital> hpt= new List<Hospital>()
            {
                new Hospital(){ id = 1, city = "Hyderabad", count = 150},
                new Hospital(){ id = 2, city = "Chennai", count = 125},
                new Hospital(){ id = 3, city = "Banglore", count = 200},
                new Hospital(){ id = 4, city = "Coimbatore", count = 50},
                new Hospital(){ id = 5, city = "Ongole", count = 75}
            };

            //For Loop
            Console.WriteLine("********************For Loop*******************\n");

            for(int i = 0; i < hpt.Count; i++)
            {
                if(hpt[i].count >= 100)
                    Console.WriteLine($"Hospital Id is: {hpt[i].id} and Hospital City is: {hpt[i].city}.");
            }

            //For Each Loop
            Console.WriteLine("\n*****************ForEach Loop******************\n");

            foreach(Hospital hp in hpt)
            {
                if(hp.count >= 100)
                    Console.WriteLine($"Hospital Id is: {hp.id} and Hospital City is: {hp.city}.");
            }
            
            //Lambda Expression
            Console.WriteLine("\n***************Lambda Expression***************\n");

            hpt.Where(hp => hp.count >= 100).ToList().ForEach(hp => Console.WriteLine($"Hospital Id is: {hp.id} and Hospital City is: {hp.city}."));

            //LINQ Query
            Console.WriteLine("\n*******************LINQ Query******************\n");

            var result = from hp in hpt
                         where hp.count >= 100
                         select hp;
            result.ToList().ForEach(hp => Console.WriteLine($"Hospital Id is: {hp.id} and Hospital City is: {hp.city}."));

            Console.ReadLine();
        }
    }
}
