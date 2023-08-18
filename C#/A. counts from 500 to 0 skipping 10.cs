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
            // Write a C# program that counts from 500 to 0 skipping 10

            for(int i = 500; i >= 0; i -= 10)
                Console.Write(i + " ");
        }
        
    }

}
