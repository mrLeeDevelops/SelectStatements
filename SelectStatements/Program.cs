using System;

namespace SelectStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 599;
            Console.WriteLine("Can you guess what my favorite number is between 1 and 1000?");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("CORRECT! Today must be your lucky day!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("TOO LOW");
            }
            else if(userInput > favNumber)
            {
                Console.WriteLine("TOO HIGH");
            }
            else Console.WriteLine("Nevermind! Stop Guessing.");
        }
    }
}
