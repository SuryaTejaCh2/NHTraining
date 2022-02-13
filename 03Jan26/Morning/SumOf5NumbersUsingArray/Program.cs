using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5NumbersUsingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initilize
            int sum = 0, avj;
            int[] data = new int[5];

            //User Input
            for(int i = 0; i < data.Length; i++)
            {
                Console.Write("Enter Number: ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            //Logic
            for(int i = 0;i < data.Length; i++)
                sum = sum + data[i];

            avj = sum / data.Length;
            
            //Output
            Console.WriteLine($"Sum of all the numbers in an array is {sum} and Average is {avj}");

            Console.ReadLine();
        }
    }
}
