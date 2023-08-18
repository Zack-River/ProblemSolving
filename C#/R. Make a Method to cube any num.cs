using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace Pyramid
{  
    class Program
    {  
        // Make a Method to cube any num

            static double kusa(int n){
            double cube = Math.Pow( n , 3);
            return cube;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Input any number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Cube of " + num + " = " + kusa(num));
        }
        
    }

}
