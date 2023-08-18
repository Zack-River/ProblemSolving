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
            // Make a C# Program to take a number and calculate his digits

            Console.Write("Input num: ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            while (n != 0)
            {
                n = n / 10;
                counter++;
            }
            Console.WriteLine("Number of digits: " + counter);
        }
        
    }

}
