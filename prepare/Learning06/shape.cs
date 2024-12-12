using System;

public abstract class Shape
{
    protected string _color ;
    public string GetColor()
    {
        return _color;

    }
    public void setColor(string color)
    {
        _color = color;
    }
    public Shape(string color)
    {
        _color = color;
    }
    public abstract double GetArea();
    

}