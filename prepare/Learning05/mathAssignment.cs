using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void setTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblem()
    {
        return _problems;

    }
    public void setProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHomeWorkList()
    {
        return $"{_textBookSection} {_problems}";
    }
}