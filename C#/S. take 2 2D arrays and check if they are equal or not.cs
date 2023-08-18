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
            // Make a C# Program to take 2 2D arrays and check if they are equal or not

            Console.Write("Input size: ");
            int size = int.Parse(Console.ReadLine());
            int [,] A = new int[size,size];
            int [,] B = new int[size,size];

            
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("Matrix 1 " + i + " * " + j + " : ");
                    A[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < size; i++)
                {
                    for(int j = 0; j < size; j++)
                    {
                        B[i,j] = int.Parse(Console.ReadLine());
                        if(A[i,j] != B[i,j])
                        {
                            Console.Write("Matrix 2 " + i + " * " + j + " : ");
                            Console.WriteLine("not equal");
                            return;
                        }  
                    }
                }
                 Console.WriteLine("equal");
        }
        
    }

}
