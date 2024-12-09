using System;
using System.ComponentModel.DataAnnotations;

public class Video
{
    public string _title = "";
    public string _author = "";

    public int _length;
    public List<Comment> _Comments;
    public string GetTitle()
    {
        return _title;
    }
    public void setTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void setAuthor(string author)
    {
        _author = author;
    }
    public int GetLength()
    {
        return _length;
    }
    public void setLength(int length)
    {
        _length = length;
    }
    public List<Comment> GetComments()
    {
        return _Comments;
    }
    public void setComment(List<Comment> comments)
    {
        _Comments = comments;
    }
    public Video(string title,string author,int length)
    {
        _author = author;
        _length = length;
        _title = title;
        _Comments = new List<Comment>();

    }
    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _Comments.Add(comment);
    }

    // Method to display video details and its comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine("Comments:");
        
        foreach (var comment in _Comments)
        {
            Console.WriteLine($"- {comment._name}: ({comment._comment})");
        }
        
    }
    public int GetCommentNumber()
    {
        return _Comments.Count;
    }

    
}