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
                        // Write a C# Program to
            // (1) take (n) numbers then put it in an array
            // (2) then rotate the first (x) numbers to the end

            Console.Write("Length: ");
            int inputs = int.Parse(Console.ReadLine());

            int [] nums = new int[inputs];

            for (int i = 0; i < inputs; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            int rot = int.Parse(Console.ReadLine());
            int [] rotarr = new int[inputs];

            for(int i = 0; i < inputs; i++)
            {
                if(i < rot)
                rotarr[inputs+i-rot] = nums[i];
                else
                rotarr[i - rot] = nums[i];
            }
            
             Console.Write("Array after left rotation " + rot + " times: ");
            for(int i = 0; i < inputs; i++)
                Console.Write( rotarr[i] + " ");
        }
        
    }

}
