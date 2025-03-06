using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage ? .");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = " B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($" Your grade is:{letter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("You failed, Better luck next time!");
        }

        if (letter != "F")
        {
            int lastDigit = (int) (grade %10);
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }

        }

        if (letter == "A" && sign == "+" )
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";  
        }
        
        string finalGrade = letter + sign ;
        Console.WriteLine($"Your final grade is {finalGrade}");
    }
}