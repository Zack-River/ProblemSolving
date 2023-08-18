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
                        // Write a C# program that search about element in one dimension array
            // if found print its index and no of occurrences
            // 1 , 6 , 10 , 5 , 10  === >> search element is 10 =====> found at index 2,4
            // no of occurrences : 2


            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int [] arr = new int [size];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("search element is: ");
            int search = int.Parse(Console.ReadLine());
            int counter = 0;
            int x =0;

            Console.Write("Found at Index: ");
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == search)
                {   
                    Console.Write(i + " ");
                    counter ++;
                    x = 1;
                }
            }

            if(x == 1)
            Console.Write("\nno of occurrences : " + counter);

            else
            {
            Console.Write("not found");
            Console.Write("\nno of occurrences : " + counter);
            }
        }
        
    }

}
