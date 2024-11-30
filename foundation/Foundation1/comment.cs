using System;
public class Comment
{
    public string _name;
    public string _comment;
    public List<Video> _videos = new List<Video>();

    

    public void Display()
    {
        Console.WriteLine($"Name of the person: {_name}");
        Console.Write($"Comment: {_comment}");
    }
}
