using System;

public class Resume
{
    public string _name;
    public List<Job> _job = new List<Job>();

    public void Dispay()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Job Name: ");

        foreach (Job job in _job)
        {
            job.Display();
        }
    }
}