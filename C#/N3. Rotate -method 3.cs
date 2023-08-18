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
            //---------------------Rotate -method 3---------------//
            int size =  int.Parse(Console.ReadLine());
            int [] arr = new int [size];
            int x;
            for(int i = 0; i< size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < size/2; i++)
            {
                x = arr[i];
                arr[i]=arr[size -i -1];
                arr[size -i -1] = x;
            }

            for(int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
    }

}
