using System;

public class ListingActivity: Activity
{
    private int _count;
    private  List<string> _prompts;
    public int GetCount()
    {
        return _count;
    }
    public void setCount(int count)
    {
        _count = count;
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }
    public void setPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
    public ListingActivity()
    {
        
        
    }
    public void Run()
    {
        
    }
    public void GetRandomPrompt()
    {
        Console.WriteLine($"{_prompts}");
    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}