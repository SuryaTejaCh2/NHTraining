using System;
using System.Xml;

/**********************************************************************
* Author: Surya Teja
* Purpose: Read xml file and print only Product names 
* *********************************************************************/

namespace XML2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument file = new XmlDocument();
            file.Load("S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Day19Feb17\\Products.xml");
            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cNode in node.ChildNodes)
                {
                    var id = cNode.Name == "Id";
                    var name = cNode.Name == "Name";
               
                    if (id)
                        Console.Write($"Product Id is {cNode.InnerText} ");
                    if (name)
                        Console.Write($"Product Name is {cNode.InnerText} \n");
                }
            }
            Console.ReadLine();
        }
    }
}
