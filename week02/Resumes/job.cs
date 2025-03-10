using System;

public class Job
{
    public string _jobTitle;
    public string _companyName;
    public string _startDate;
    public string _endDate;

    public void Display ()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate}-{_endDate}");
    }
}
