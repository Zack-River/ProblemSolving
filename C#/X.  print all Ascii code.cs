using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace Pyramid
{  
    class Program
    {  
        static void Main(string[] args)
        {
            // Make a C# Program to print all Ascii code

            int a;
            int i = 0;
            for (a = 0; a <= 255; a++)
            {
                Console.WriteLine("ASCII value of character " + Convert.ToChar(a) + " = " + i);
                i++;
            }

            /* if u want to input */
            Console.Write("\n\n\n\n\nWrite the num to change it to ascii:");
            int x = int.Parse(Console.ReadLine());
            char y = (char)x;
            Console.WriteLine("ASCII value of Number " + x + " = " + y);

            /* ascii to num */

            Console.Write("\n\n\n\n\nWrite the ascii sympol to change it to num:");
            char s = char.Parse(Console.ReadLine());
            int z = (int)s;
            Console.WriteLine("ASCII value of Character " + s + " = " + z);
        }
        
    }

}
