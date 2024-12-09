using System;
public class Comment
{
    public string _name;
    public string _comment;
    public string GetName()
    {
        return _name;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public string GetComment()
    {
        return _comment;
    }
    public void setComment(string Comment)
    {
        _comment = Comment;
    }
    public Comment(string name,string Comment)
    {
        _name = name;
        _comment = Comment;
    }

}
