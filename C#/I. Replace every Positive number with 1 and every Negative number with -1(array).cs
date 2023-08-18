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
                        /*Declare and create array of 5 elements and Read 5 numbers then Replace
                  every Positive number with 1 and every Negative number with -1*/

            int [] arr = new int [5];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if(arr[i] > 0)
                arr[i] = 1;
                else if(arr[i] < 0)
                arr[i] = -1;
            }

            for(int i =0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if(arr.Length != i+1)
                Console.Write(", ");
            }
        }
        
    }

}
