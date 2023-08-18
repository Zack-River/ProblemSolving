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
            //-----------------------------Rotate Method 1-----------------------//
             int size =  int.Parse(Console.ReadLine());
            int [] arr = new int [size];
            

            for(int i = size-1; i >= 0; i--)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        
    }

}
