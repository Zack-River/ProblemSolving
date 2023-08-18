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


                    //---------------------Method 1---------------//
            string input;
            int spaces = 0;

            Console.Write("Enter Text: ");
            input = Console.ReadLine();
            for(int i =0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    spaces++;
                }
            }
            Console.Write("The Number Of Spaces = " + spaces);
        }
        
    }

}
