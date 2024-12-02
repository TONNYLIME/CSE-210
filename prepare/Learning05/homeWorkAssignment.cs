using System;
using System.Reflection;

public class HomeWorkAssgnment : Assignment
{
    private string _title = "";
     
    public string GetTitle()
    {
        return _title;
    }
    public void setTitle(string title)
    {
        _title = title;
    }
    public String GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}