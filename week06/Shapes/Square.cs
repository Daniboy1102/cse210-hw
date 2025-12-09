using System;

public class Square : Shape
{
    private double _side; // Store the length of the side

    // Constructor to set color and side
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea method for square
    public override double GetArea()
    {
        return _side * _side; // Area = side^2
    }
}