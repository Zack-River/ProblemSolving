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
            // Make a C# Program to find all factors

            Console.Write("Input num: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Factors of 12: ");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (n == i)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    Console.Write(i + ", ");
                }
            }
        }
        
    }

}
