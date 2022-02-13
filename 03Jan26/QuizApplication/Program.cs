using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, answer;
            string name;

            Console.Write("Enter your Name: ");
            name =  Console.ReadLine();

            Console.WriteLine("**************************************");
            Console.WriteLine($"Hi {name} welcome to quiz by Surya");
            Console.WriteLine("**************************************");

            Console.WriteLine("\nQ1. What is the national game of India ");
            Console.WriteLine("1.Cricket 2.Field Hockey 3.Badminton 4.Kabaddi");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
                score += 20;

            Console.WriteLine("\nQ2. What is the national game of USA ");
            Console.WriteLine("1.Tennis 2.Ice Hockey 3.Baseball 4.Football");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 3)
                score += 20;

            Console.WriteLine("\nQ3. What is the national game of Israel ");
            Console.WriteLine("1.Swimming 2.Field Hockey 3.Basketball 4.Football");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 4)
                score += 20;

            Console.Write("\nQ4. What is the national game of Scotland: ");
            Console.WriteLine("1.Golf 2.Tennis 3.Football 4.Rugby");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
                score += 20;

            Console.WriteLine("\nQ5. What is the national game of England ");
            Console.WriteLine("1.Rugby  2.Cricket 3.Football 4.Basketball");
            Console.Write("Enter your choice: ");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 2)
                score += 20;

            if (score >= 60)
                Console.WriteLine($"\nCongratulation {name}, you got {score}% in this quiz");
            else
                Console.WriteLine($"\nSorry {name}, you got only {score}%. Try again");

            Console.ReadLine();
        }
    }
}
