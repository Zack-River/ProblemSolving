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
                        // Make an array of 5 elements and find sum of its  positive values and average of them

             int sum = 0;
             int [] arr = new int [5];

             for(int i = 0; i < arr.Length; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());

                 if(arr[i] > 0)
                 {
                     sum += arr[i];
                 }
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + sum/arr.Length); 
        }
        
    }

}
