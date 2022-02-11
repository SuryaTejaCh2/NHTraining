using System;
using System.IO;
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
            string fileName = "S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Feb11\\ExampleFiles\\Score.txt";

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
            //Adding Score to File
            if (File.Exists(fileName))
                File.Delete(fileName);
            Console.WriteLine("\n*****File Deleted*****\n");

            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(name);
            sw.WriteLine(score);
            sw.Close();
            Console.WriteLine("*****Score Added*****");
            Console.WriteLine($"\nThanks, {name} score was added to our company server");

            Console.ReadLine();
        }
    }
}
