using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int usersNumber = -1;
        while (usersNumber != 0)
        {
            Console.WriteLine("Enter a number (Type 0 to quit): ");

            string usersRespond = Console.ReadLine();
            usersNumber = int.Parse(usersRespond);


            if (usersNumber != 0)
            {
                numbers.Add(usersNumber);
            }
            
        }
        //compute the sum of the numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The Sum is:{sum}");


        // compute the average of the numbers
       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average is:{average}");

        // compute the max of the numbers
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");



       

    }
}