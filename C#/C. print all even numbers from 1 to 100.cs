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
                        // Write C# Program to print all even numbers from 1 to 100

            for (int i = 0; i <= 100; i+=2) //even numbers from 1 to 100
            {
                Console.Write(i);

                if(i != 100)
                Console.Write(" ");
            }
        }
        
    }

}
