using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
namespace Pyramid
{  
    class Program
    {  
                //Write C# Program to verify username and password using method
            // user name = admin    , password = 123

        static void verify(string input_name, int input_pass)  <<======== Method
        {
            string user_name = "admin";
            int user_pass = 123;
            
            if(input_name == user_name && input_pass == user_pass)
            {
                Console.WriteLine("Welcome, You logged in Successefully");
                return;
            }

            Console.WriteLine("Sorry the User Name or your Password Is Wrong , Please Try Again");
            return;

        }


        static void Main(string[] args)
        {
            Console.Write("UserName: ");
            string user_name = Console.ReadLine();

            Console.Write("Password: ");
            int user_pass = int.Parse(Console.ReadLine());
            verify(user_name,user_pass);
        }
        
    }

}
