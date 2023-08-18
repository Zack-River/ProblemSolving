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
            // Write a C# Program to input n numbers and calculate how many even and odd

            Console.Write("How many nums you want to input: ");
            int inputs = int.Parse(Console.ReadLine());
            int even , odd; even = odd = 0;
            int [] nums = new int[inputs];
            for (int i = 0; i < inputs; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if(nums[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("Total even elements:" + even);
            Console.WriteLine("Total odd elements:" + odd);
        }
        
    }

}
