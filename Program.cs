using System;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");

            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 > num1) 
            {
                Console.WriteLine("Number 2 is greater than number 1");
            }
            else if (num1 > num2) 
            {
                Console.WriteLine("Number 1 is greater than number 2");
            }

            else
            {
                Console.WriteLine("The numbers are equal");
            }

            
          //  Console.WriteLine("Thankyou");

          string name = "Sandra Makena";
          string password = "stars";
          string pin = "7654";
        
          Console.WriteLine("Enter your name");
          string name1 = Console.ReadLine();
          Console.WriteLine("Enter your password");
          string password1 = Console.ReadLine();
W          string pin1 = Console.ReadLine();

          if ((name == name1) && (password == password1) && (pin == pin) )
          {
              Console.WriteLine("Log in successfull. Welcome to Wild Springs");
          }
          else
          {
              Console.WriteLine("Log in failed Please try again");
          }
          
            Console.ReadKey();
        }

    }
}