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
            //---------------------Rotate -method 2---------------//
            int size =  int.Parse(Console.ReadLine());
            int [] arr = new int [size];
            int [] arr2 = new int [size];

            for(int i = 0; i< size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                arr2[size - i - 1] = arr[i];
            }

            for(int i = 0; i < size; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
        
    }

}
