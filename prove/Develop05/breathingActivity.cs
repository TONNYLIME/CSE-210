using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description,int duration) : base(name,description,duration)
    {
        
        Console.WriteLine("Breath out..");
        Thread.Sleep(5000);
        Console.WriteLine("Breath in...");
        Thread.Sleep(5000);
        Console.WriteLine("Breath out..");
        Thread.Sleep(5000);
        Console.WriteLine("Breath in...");
        Thread.Sleep(5000);
        Console.WriteLine("Breath out..");
        Thread.Sleep(5000);
        Console.WriteLine("Breath in...");
        Thread.Sleep(5000);
        Console.WriteLine("Breath out..");
        Thread.Sleep(5000);
    }

    public void Run()
    {
        return;
    }

    
}
