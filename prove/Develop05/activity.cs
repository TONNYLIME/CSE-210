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
    public Activity(string name, string description,int duration)
    {
        Console.WriteLine("Menu option");
        Console.WriteLine("  1 Start Breathing Activity.");
        Console.WriteLine("  2 Start listing activity.");
        Console.WriteLine("  3 Start reflecting activity.");
        Console.WriteLine("  4 Quit.");
        Console.WriteLine("Select a choice from the menu: ");
        
        
        
      {
       return ;
      }
      //_name = name;
      //_description = description;
      //_duration = duration;
    
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
        
    }
    public void ShowCountDown(int seconds)
    {
        
    }
    
    

    
}