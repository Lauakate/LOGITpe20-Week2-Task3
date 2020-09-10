using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that checks whether a given number is negative or positive

            int Number;
            string UserInput;

            Console.WriteLine("Insert a negative or positive number.");
            UserInput = Console.ReadLine();
            Number = Int32.Parse(UserInput);

            if (Number > 0)
            {
                Console.WriteLine("That number is positive.");

            }
            else if (Number < 0)
            {
                Console.WriteLine("That number is negative.");
            }
            else
            {
                Console.WriteLine("That number is equal to 0");
            }

                
            
               

           
            
         
                    

            











        }
    }
}
