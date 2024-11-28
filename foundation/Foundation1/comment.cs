using System;
public class Comment
{
    public string _name;
    public string _comment;

    public Comment(string name,string comment)
    {
        Console.WriteLine($"Name of the person: {_name}");
        Console.Write($"Comment: {_comment}");
    }
}
