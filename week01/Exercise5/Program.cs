using System;

class Program
{
    static void Main(string[] args)
    {
      DisplayWelcomeMessage();
      string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int userSquared = SquareNumber(userNumber);

        DisplayResults(userName, userSquared);

    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write($"Please enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int userSquared = userNumber * userNumber;
        return userSquared;
    }

    static void DisplayResults(string userName, int userSquared )
    {
        Console.WriteLine($"{userName}, your squared number is {userSquared}");

    }
}