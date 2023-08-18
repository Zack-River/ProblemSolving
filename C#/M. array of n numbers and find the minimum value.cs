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
                        //Create an array of n numbers and find the minimum value of them

              int min = int.MaxValue;
              Console.Write("How many nums you will input: ");

              int size = int.Parse(Console.ReadLine());
              int [] arr = new int [size];

              for(int i = 0; i < arr.Length; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());

                    if( arr[i] < min)
                    {
                        min = arr[i];
                    }
            }

            Console.WriteLine("Min = " + min);
        }
        
    }

}
