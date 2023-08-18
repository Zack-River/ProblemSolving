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
            // Make a C# Program to swap first and last  digit

            /* way 1 */ /* without math or log */
            Console.Write("Input num: ");
            int n = int.Parse(Console.ReadLine());
            int last = n % 10;
            int first = n;
            int body = n;
            int counter = 0;

            while (first > 9)
            {
                first = first / 10;
                counter++;
            }

            int minus = first;

            for (int i = 0; i < counter; i++)
            {
                minus *= 10;
            }

            body = body - minus;
            body = body / 10;

            Console.WriteLine("Number after swapping first and last digit:" + last + "" + body + "" + first);
        }
        
    }

}
