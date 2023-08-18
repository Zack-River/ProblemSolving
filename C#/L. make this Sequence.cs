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
            // Write C# program to make this Sequence
            /*
            1
            2 3
            4 5 6
            7 8 9 10
            11 12 13 14 15
            */

            Console.Write("Enter How many Lines Do you Want to print: ");
            int lines =  int.Parse(Console.ReadLine());

            for(int i = 1 , x = 1; i <= lines; i++)
            {
                
                for(int j = 1 ;j <= i; j++)
                {
                    Console.Write((x) + " ");
                    x++;
                }
                Console.WriteLine();
            }
        }
        
    }

}
