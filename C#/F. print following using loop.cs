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
             // Write a C# program to print following using loop
            /*
            *
            * *
            * * *
            * * * * 
            */

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                    if(j != i)
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        
    }

}
