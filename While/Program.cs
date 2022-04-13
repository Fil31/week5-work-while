using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopactive = true; //Boolean -true/false
            int counter = 0;

            while (loopactive)
            {
                if (counter == 3)
                {
                    Console.WriteLine("You have used all the attempts to log in.");
                    break;
                }
                Console.WriteLine("Enter your PIN:");
                string userPin = Console.ReadLine();
                if(userPin == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                }    
                else
                {
                    Console.WriteLine("Invalid PIN. Try again.");
                    counter++;
                    Console.WriteLine($"You have used {counter} tries.");
                }
            }
            Console.WriteLine("Have a good day.");
        }
    }
}
