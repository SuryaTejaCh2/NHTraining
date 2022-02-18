using System;
using System.Xml;

/**********************************************************************
* Author: Surya Teja
* Purpose: Write C# code to read xml file and print Content
* *********************************************************************/

namespace XML3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument file = new XmlDocument();
            file.Load("S:\\NB\\Assi\\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\\C#\\Day19Feb17\\Products.xml");
            foreach(XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cNode in node.ChildNodes)
                {
                    var id = cNode.Name == "Id";
                    var name = cNode.Name == "Name";
                    var brand = cNode.Name == "Brand";
                    if (id)
                        Console.Write($"{cNode.InnerText}, ");
                    if (name)
                        Console.Write($"{cNode.InnerText}, ");
                    if (brand)
                        Console.Write($"{cNode.InnerText} \n");
                }
            }
            Console.ReadLine();
        }
    }
}
