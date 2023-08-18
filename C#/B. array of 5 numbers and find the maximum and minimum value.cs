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
            //Create an array of 5 numbers and find the maximum and minimum value of them

              int max = int.MinValue, min = int.MaxValue;
              int [] arr = new int [5];

              for(int i = 0; i < arr.Length; i++)
             {
                 arr[i] = int.Parse(Console.ReadLine());
        

                    if(arr[i] > max)
                        max=arr[i];

                    if( arr[i] < min)
                    {
                        min = arr[i];
                    }
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }
        
    }

}
