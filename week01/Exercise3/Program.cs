using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;
        int guessCount = 0;// Tracked the guesses of the user

        while (guess != number)
        {
            Console.Write("Guess a number between 1 and 100: ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            guessCount++;

            if (guess < number)
            {
                Console.WriteLine("Too low, Try again!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high, Try again!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
            
        }

        Console.WriteLine($" Took you {guessCount} guess to get the number{number}.");
    }
}