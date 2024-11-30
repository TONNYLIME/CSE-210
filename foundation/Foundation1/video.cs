using System;

public class Video
{
    public string _title;
    public string _author;

    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public void GetCommentsNumber()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.Write($"Video Author: {_author}");
        Console.Write($"Video Length: {_length}s.");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            // This calls the Display method on each comment
            comment.Display();
        }
    }
    



}