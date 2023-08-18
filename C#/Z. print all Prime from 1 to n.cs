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
            // Make a C# Program to print all Prime from 1 to n

            Console.Write("Input lower limit: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Input upper limit: ");
            int u = int.Parse(Console.ReadLine());

            bool prime = true;
            Console.Write("Prime numbers between " + l + "-" + u + ": ");
            for (int i = l; i <= u; i++) //upper limit and lower limit are defined
            {
                if (i == 1)
                    continue;
                for (int j = 2; j <= Math.Sqrt(i); j++)// base logic for the primality
                {
                    if (i != j && i % j == 0) //modulo operators employed
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.Write("\t" + i); //printing the correct variable
                }
                prime = true;
            }
        }
        
    }

}
