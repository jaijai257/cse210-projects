using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._companyName = "Google";
        job1._startDate = "01/01/2020";
        job1._endDate = "01/01/2021";
       

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._companyName = "Facebook";
        job2._startDate = "01/01/2019";
        job2._endDate = "01/01/2020";
        

        Resume myResume = new Resume();
        myResume._name = "John White";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}