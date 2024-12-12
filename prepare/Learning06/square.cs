using System;
using System.Runtime.CompilerServices;

public class Square : Shape
{
    private double _side ;
     
    public double GetSide()
    {
        return _side;
    }
    public void setSide(double side)
    {
        _side = side;
    }
    public Square(string color, double side) : base(color)
    {
        _side = side;
        _color = color;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}