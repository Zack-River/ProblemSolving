using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace Pyramid
{  
    class Program
    {  
        // Write a C# program to calculate Factorial of n (Using Method)
            //  if n = 5  ====> fact = 120

        static void factorial(int n)  <<======== Method
        {
            int factorial = 1;
             if (n == 1 || n == 0)
             {
                  Console.WriteLine("Factorial = " + 1);
                    return;
             }

             else if(n > 1)
             {
            
               for(int i = n; i > 1 ; i--)
               {
                     factorial *= i; 
               }

             Console.WriteLine("Factorial = " + factorial);
             return;
             }

             Console.WriteLine("No factorial for negative numbers");
             return;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            factorial[n];
        }
        
    }

}
