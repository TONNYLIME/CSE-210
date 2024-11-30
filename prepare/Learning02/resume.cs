using System;

public class Resume
{
    public string _name;
<<<<<<< HEAD
    public List<Job> _job = new List<Job>();

    public void Dispay()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Job Name: ");

        foreach (Job job in _job)
=======
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
>>>>>>> 2a58bd2b5d412134ca9b1dd0b9514b345773fb54
        {
            job.Display();
        }
    }
}