using System;
using System.Xml;

/**********************************************************************
* Author: Surya Teja
* Purpose: Read xml file and print the content from the file.
* *********************************************************************/

namespace XML1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument file = new XmlDocument();
            file.Load("S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Day19Feb17\\Products.xml");
            foreach(XmlNode node in file.DocumentElement.ChildNodes)
            {
                Console.WriteLine(node.InnerText);
            }
            Console.ReadLine();
        }
    }
}
