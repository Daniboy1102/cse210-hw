using System;

public class Shape
{
    // Member variable to store the color of the shape
    private string _color;

    // Constructor to set the color
    public Shape(string color)
    {
        _color = color;
    }

    // Method to get the color
    public string GetColor()
    {
        return _color;
    }

    // Virtual method to get the area
    // This will be overridden by derived classes
    public virtual double GetArea()
    {
        return 0; // Base class does not know the area
    }
}