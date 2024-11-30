using System;

public class Job
{
<<<<<<< HEAD
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}.");
    }
}


=======
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    
}
>>>>>>> 2a58bd2b5d412134ca9b1dd0b9514b345773fb54
