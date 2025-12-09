using System;

// Swimming activity
class Swimming : Activity
{
    private int _laps; // number of laps
    private const double LapDistanceKm = 50.0 / 1000; // 50 meters per lap in km

    public Swimming(DateTime date, double minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapDistanceKm;

    public override double GetSpeed() => (GetDistance() / Minutes) * 60; // km/h

    public override double GetPace() => Minutes / GetDistance(); // min per km
}
