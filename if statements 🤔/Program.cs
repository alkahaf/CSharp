using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age >= 18 && age < 50)
            //{
            //    Console.WriteLine("You Welcome");
            //}



            //else if (age == 0)
            //{

            //    Console.WriteLine("enter correct age");
            //}

            //else
            //{
            //    Console.WriteLine("You are not allowed");
            //}

            Console.WriteLine("Enter your name:");
            String name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Hello " + name);
               
            }
            else
            {
                Console.WriteLine("you did not enter your name!!");
            }
            Console.ReadKey();
        }
    }

}