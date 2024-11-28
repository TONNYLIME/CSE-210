using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string Content {get;}
    public Entry(string dateInput , string content)
    {
      _date = dateInput; 
      Content = content;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
    }
}