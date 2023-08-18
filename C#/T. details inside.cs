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
            // Make a C# Program to calculate area then if
            // area more than 1000 price per km is 5000 and print price and large area
            // else price = 2000 per km and print price and small area

            int l , w , area , price ;

            Console.Write("Enter Length: ");
            l = int.Parse(Console.ReadLine());
            while ( l <= 0)
            {
                Console.Write("Uncorrect length\nEnter Length: ");
                l = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter Width: ");
            w = int.Parse(Console.ReadLine());
            while ( w <= 0)
            {
                Console.Write("Uncorrect width\nEnter Width: ");
                w = int.Parse(Console.ReadLine());  
            }

            area  = l * w ;

            if (area >= 1000)
            {
                Console.WriteLine("Large area\nSize: ");
                price = area * 5000; 
                Console.WriteLine("Price: "+ price);
            }

            else
            {
                Console.WriteLine("Small area\nSize: ");
                price = area * 2000; 
                Console.WriteLine("Price: "+ price);
            }
        }
        
    }

}
