using System;

// Base class for all goal types
public abstract class Goal
{
    protected string _shortName;   // Short name of the goal
    protected string _description; // Description of the goal
    protected int _points;         // Points earned for completing or recording the goal

    // Constructor to initialize goal
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Accessors
    public string ShortName => _shortName;
    public string Description => _description;
    public int Points => _points;

    // Record progress for the goal; returns points earned
    public abstract int RecordEvent();

    // Check if goal is complete
    public abstract bool IsComplete();

    // Get goal details for display
    public virtual string GetDetailsString() => $"{_shortName}: {_description}";

    // Convert goal to string for saving
    public abstract string GetStringRepresentation();
}
