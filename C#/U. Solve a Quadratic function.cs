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
            // Make a C# Program to Solve a Quadratic function

            Console.Write("Factor of X^2 (a) =");
            double a =  double.Parse(Console.ReadLine());

            while (a == 0)
            {
                Console.Write("0 not acceptable, Try again \nFactor of X^2 (a) =");
                a =  double.Parse(Console.ReadLine());
            }

            Console.Write("Factor of X (b) =");
            double b =  double.Parse(Console.ReadLine());

            Console.Write("absolute limit (c) =");
            double c =  double.Parse(Console.ReadLine());

            double under_root = Math.Pow(b,2) - (4 * a * c);
    
            // UNDER root < 0 undefined
            while (b*b < 4*a*c)
            {
            
            // Cofactor X^2 = 0 undefined
            while (a == 0)
            {
                Console.Write("0 not acceptable, Try again \nFactor of X^2 (a) =");
                a =  double.Parse(Console.ReadLine());
            }

            Console.Write("Factor of X (b) =");
            b =  double.Parse(Console.ReadLine());

            Console.Write("absolute limit (c) =");
            c =  double.Parse(Console.ReadLine());

            under_root = Math.Pow(b,2) - (4 * a * c);
            }

            double x1= (-b + Math.Pow(under_root,0.5))/(2*a);
            double x2= (-b - Math.Pow(under_root,0.5))/(2*a);
            Console.WriteLine("First Solution X=" + x1 + "\nSecond Solution X=" + x2);
        }
        
    }

}
