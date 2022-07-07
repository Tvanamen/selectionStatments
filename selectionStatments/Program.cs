using System;

namespace selectionStatments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();
            var favNumber = randomNumber.Next(1, 100);
            Console.WriteLine("Please guess a number between 1 and 500");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("Good guess you got it!");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Guess was too low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Guess was too high!");
            }
            if (userInput != favNumber)
            {
                Console.WriteLine("thanks for playing");
            }


        }
    }
}
