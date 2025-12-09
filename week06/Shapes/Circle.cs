using System;

public class Circle : Shape
{
    private double _radius; // Store radius

    // Constructor to set color and radius
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea method for circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius; // Area = π * r^2
    }
}