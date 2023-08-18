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
                        // Write a C# program that produces the result of multiplpcation
            // of the number 3 with all integer numbers from 1 to 10

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("3 * " + i + " = " + (3*i));
            }
        }
        
    }

}
