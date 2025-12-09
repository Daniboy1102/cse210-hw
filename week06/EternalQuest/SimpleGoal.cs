using System;

// Simple goal: completed only once
public class SimpleGoal : Goal
{
    private bool _isComplete;  // Tracks if the goal has been completed

    // Constructor
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Record completion; award points if not already completed
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    // Return true if goal is complete
    public override bool IsComplete() => _isComplete;

    // Display goal with completion status
    public override string GetDetailsString() => $"{_shortName}: {_description} [{(_isComplete ? "X" : " ")}]";

    // Convert goal to string for saving
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    // Recreate goal from saved string
    public static SimpleGoal CreateFromString(string data)
    {
        var parts = data.Split(',');
        var goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]))
        {
            _isComplete = bool.Parse(parts[3])
        };
        return goal;
    }
}
