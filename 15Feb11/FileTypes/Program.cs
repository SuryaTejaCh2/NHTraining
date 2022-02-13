using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
* Author: Surya Teja
* Purpose: File methods
* *********************************************************************/

namespace FileTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File Location
            string fileName = "S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Feb11\\ExampleFiles\\Sample.txt";
            string fileName1 = "S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Feb11\\ExampleFiles\\Destination\\Sample.txt";
            
            // Check File Exist or not and Delete the file     
            if (File.Exists(fileName))
                File.Delete(fileName);
            Console.WriteLine("*****File Deleted*****\n");

            // Create a new file and add text
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine("Hi All");
            sw.WriteLine("AWelcome to");
            sw.WriteLine("Nations Benefit");
            sw.Close();
            Console.WriteLine("\n*****Text Added*****");
            
            // Read File     
            StreamReader sr = File.OpenText(fileName);
            string s = "";
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);
            Console.WriteLine("\n*****Read Line*****");
            sr.Close();
            

            if (File.Exists(fileName1))
                File.Delete(fileName1);
            File.Move(fileName, fileName1);
            Console.WriteLine("\n*****File was moved*****");

            //Copy File
            File.Copy(fileName1, fileName);
            Console.WriteLine("\n*****File was Copied*****");
            object date = File.GetCreationTime(fileName1);
            Console.WriteLine("\n*****Get Creation Time*****");
            Console.WriteLine(date);

            //Open File
            File.OpenText(fileName1).Close();
            Console.WriteLine("\nFile Opened");

            //Append new Text
            sw = File.AppendText(fileName1);
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
            sw.Close ();
            Console.WriteLine("\nFile Append");

            //Read File
            object read = File.ReadAllText(fileName1);
            Console.WriteLine(read);
            Console.WriteLine("\nRead Appended File");

            Console.ReadLine();
        }
    }
}