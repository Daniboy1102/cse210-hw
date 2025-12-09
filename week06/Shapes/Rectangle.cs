using System;

public class Rectangle : Shape
{
    private double _length; // Store length
    private double _width;  // Store width

    // Constructor to set color, length, and width
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override GetArea method for rectangle
    public override double GetArea()
    {
        return _length * _width; // Area = length * width
    }
}