using System;

// Base class for all activities
abstract class Activity
{
    private DateTime _date;   // Date of activity
    private double _minutes;  // Duration in minutes

    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Public properties to access private variables
    public DateTime Date => _date;
    public double Minutes => _minutes;

    // Abstract methods to be implemented by derived classes
    public abstract double GetDistance(); // in km
    public abstract double GetSpeed();    // in km/h
    public abstract double GetPace();     // min per km

    // General summary method for all activities
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min/km";
    }
}
