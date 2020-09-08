using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When were you born?");
          
            string Userinput;
            Userinput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(Userinput);
            int Age = 2020 - Year;
            if (Age < 18)
            {
                Console.WriteLine($"you are too young to get a drivers license.");


            }
            else if (Age > 18)
            {
                Console.WriteLine("you are old enough to get a driver license.");
                    }




        }
    }
}
