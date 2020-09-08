using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1;
            int Number2;
            string UserInput;
            string UserInput2;

            Console.WriteLine("Choose number one");
            UserInput = Console.ReadLine();
            Number1 = Int32.Parse(UserInput);
            Console.WriteLine("Choose number two");
            UserInput2 = Console.ReadLine();
            Number2 = Int32.Parse(UserInput2);

            if (Number1 > Number2)
            {
                Console.WriteLine($"{Number1} is bigger than {Number2}");
            }
            else if (Number1 < Number2)
            {
                Console.WriteLine($"{Number1} is smaller than {Number2}");
            }
            else
            {
                Console.WriteLine($"{Number1} is equal to {Number2}");
            }
                    

        }
    }
}
