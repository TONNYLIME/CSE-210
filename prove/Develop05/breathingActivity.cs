using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string description ,string name ,int duration): base(description, name,duration)
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
       
    }

    public void Run()
    {
        Console.WriteLine($"{_description}");
    }

    
}
