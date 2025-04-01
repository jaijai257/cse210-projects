using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Beaker", "Algebra");  
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Lori White", "Addition", "3.5", "11-22");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WriteAssignment a3 = new WriteAssignment("Michael Smith", "Europen History","The Cause of World War II" );
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}