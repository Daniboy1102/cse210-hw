using System;

// Running activity
class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, double minutes, double distance) 
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / Minutes) * 60; // km/h

    public override double GetPace() => Minutes / _distance; // min per km
}
