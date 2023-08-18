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

            //Write a program that reads characters from the keyboard until a period is received. Have the 
            //program count the number of spaces. Report the total number of spaces at the end of the 
            //program.

                    //---------------------Method 2---------------//
            int x = 1;
            int spaces = 0;

            Console.Write("Enter Text: ");
            while(x != '.')
            {
                x = Console.Read();
                if((char)x == ' ')
                {
                    spaces++;
                }
            }
            Console.Write("The Number Of Spaces = " + spaces);
        }
        
    }

}
