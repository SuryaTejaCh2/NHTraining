using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter any single Character");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'I':
                case 'i':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine($"The Character {ch} is Vowel");
                    break;
                default:
                    Console.WriteLine($"The Character {ch} is not Vowel");
                    break;
            }

            Console.ReadLine(); 
        }
    }
}
