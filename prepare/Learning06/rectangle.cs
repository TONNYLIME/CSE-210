using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public double GetLength()
    {
        return _length;
    }
    public void setLength(double length)
    {
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void setWidth(double width)
    {
        _width = width;
    }
    public Rectangle(string color,double length, double width) : base(color)
    {
        _color = color;
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
}