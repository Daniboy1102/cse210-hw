using System;

// Checklist goal: repeat N times to complete, awards bonus points at the end
public class ChecklistGoal : Goal
{
    private int _amountCompleted;  // How many times goal has been completed
    private int _target;           // Required number of completions
    private int _bonus;            // Extra points when goal is completed

    // Constructor
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Record completion and award points (bonus on final completion)
    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            if (IsComplete()) return _points + _bonus;
            return _points;
        }
        return 0;
    }

    // Check if goal is complete
    public override bool IsComplete() => _amountCompleted >= _target;

    // Display goal with progress
    public override string GetDetailsString() => $"{_shortName}: {_description} Completed {_amountCompleted}/{_target}";

    // Convert goal to string for saving
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    // Recreate goal from saved string
    public static ChecklistGoal CreateFromString(string data)
    {
        var parts = data.Split(',');
        var goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[5]))
        {
            _amountCompleted = int.Parse(parts[3])
        };
        return goal;
    }
}
