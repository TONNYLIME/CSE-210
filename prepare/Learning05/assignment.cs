using System;
public class Assignment
{
    protected string _studentName ="";
    protected string _topic ="";
    public string GetStudentName()
    {
        return _studentName;
    }
    public void setStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void setTopic(string topic)
    {
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} -{_topic}";
    }
}