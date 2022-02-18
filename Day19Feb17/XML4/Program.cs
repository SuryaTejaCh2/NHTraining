using System;
using System.Xml;

/**********************************************************************
* Author: Surya Teja
* Purpose: Read Employee ID from user and write C# code to get the employee name
* *********************************************************************/

namespace XML4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            XmlDocument file = new XmlDocument();
            file.Load("S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Day19Feb17\\Products.xml");
            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach(XmlNode cNode in node.ChildNodes)
                {
                    bool id = cNode.Name == "Id";
                    bool isIndex = (id == true ? Convert.ToInt32(cNode.InnerText)  : 0) == input;
                    if (id && isIndex)
                    {
                        Console.WriteLine($"Name is {cNode.NextSibling.InnerText}.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
