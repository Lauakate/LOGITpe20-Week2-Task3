using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;

            Console.WriteLine("What is your favorite animal?)");
            UserInput = Console.ReadLine();

            if (UserInput == "dog")
            {
                Console.WriteLine("People who love dogs are partygoers.");
            }
            else if (UserInput == "cat")
            {
                Console.WriteLine("People who love cats are homebirds");
            }
            else
            {
                Console.WriteLine($"You are a {UserInput} lover.");
            }


        }
    }
}
