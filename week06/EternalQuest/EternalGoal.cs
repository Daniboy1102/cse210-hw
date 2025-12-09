using System;

// Eternal goal: never completes, points earned each time
public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points) { }

    // Always award points
    public override int RecordEvent() => _points;

    // Eternal goal never completes
    public override bool IsComplete() => false;

    // Display goal with infinity symbol
    public override string GetDetailsString() => $"{_shortName}: {_description} [∞]";

    // Convert goal to string for saving
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }

    // Recreate goal from saved string
    public static EternalGoal CreateFromString(string data)
    {
        var parts = data.Split(',');
        return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
    }
}
