using System;

public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    public string GetName()
    {
        return _name;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public string GetDescripton()
    {
        return _description;
    }
    public void setDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void setDuration(int duration)
    {
        _duration = duration;
    }
    public Activity(string description, string name,  int duration)
    {
        _description = description;
        _name = name;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_description}");
    }
    
    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine($"");
    }
    public void ShowCountDown(int seconds)
    {
        Console.WriteLine($"");
    }

    

    internal static void ListingActivity()
    {
        throw new NotImplementedException();
    }

    internal static void ReflectingActivity()
    {
        throw new NotImplementedException();
    }

    internal static void BreathingActivity()
    {
        throw new NotImplementedException();
    }
}