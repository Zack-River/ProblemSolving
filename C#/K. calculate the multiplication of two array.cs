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
            // Write a C# program to calculate the multiplication of two array
            //and display it's result in another array

            Console.Write("Enter Array Size: ");
            int size = int.Parse(Console.ReadLine());

            int [] arr1 = new int[size];
            int [] arr2 = new int[size];
            int [] result = new int[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i+1) + " element in array 1: ");
                arr1[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter " + (i+1) + " element in array 2: ");
                arr2[i] = int.Parse(Console.ReadLine());

                result[i] = arr1[i] * arr2[i];
            }

            for(int i = 0; i < size; i++)
            {   
                if(i == 0)
                Console.Write("Res: ");

                Console.Write(result[i] + " ");
            }
        }
        
    }

}
