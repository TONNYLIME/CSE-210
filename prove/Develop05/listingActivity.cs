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
    public ListingActivity(string name, string description,int duration,int count) : base(name,description,duration)
    {
        _name =name;
        _description = description;
        _duration = duration;
        _count = count;
        
        
    }
    public void Run()
    {
        
    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}