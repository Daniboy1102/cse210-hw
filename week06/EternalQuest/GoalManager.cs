using System;
using System.Collections.Generic;
using System.IO;

// Manages all goals and the user's score
public class GoalManager
{
    private List<Goal> _goals;  // List of all goals
    private int _score;          // User's current score
    private const string FileName = "goals.txt"; // File for saving/loading

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1-Simple 2-Eternal 3-Checklist");
        var type = Console.ReadLine();
        Console.Write("Goal Short Name: ");
        var shortName = Console.ReadLine();
        Console.Write("Description: ");
        var description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        // Add goal based on type
        if (type == "1") _goals.Add(new SimpleGoal(shortName, description, points));
        else if (type == "2") _goals.Add(new EternalGoal(shortName, description, points));
        else if (type == "3")
        {
            Console.Write("Target amount: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }
    }

    // Record progress for a goal
    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");

        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
            _score += _goals[index].RecordEvent();
    }

    // Display all goals and current score
    public void ShowGoals()
    {
        Console.WriteLine($"\nCurrent Score: {_score}");
        foreach (var goal in _goals)
            Console.WriteLine(goal.GetDetailsString());
    }

    // Save goals and score to file
    public void SaveGoals()
    {
        using StreamWriter writer = new StreamWriter(FileName);
        writer.WriteLine(_score); // First line is score
        foreach (var goal in _goals)
            writer.WriteLine(goal.GetStringRepresentation());
    }

    // Load goals and score from file
    public void LoadGoals()
    {
        _goals.Clear();
        if (!File.Exists(FileName)) return;

        var lines = File.ReadAllLines(FileName);
        if (lines.Length > 0) int.TryParse(lines[0], out _score);

        for (int i = 1; i < lines.Length; i++)
        {
            var line = lines[i];
            var type = line.Split(':')[0];
            var data = line.Substring(line.IndexOf(':') + 1);

            Goal goal = type switch
            {
                "SimpleGoal" => SimpleGoal.CreateFromString(data),
                "EternalGoal" => EternalGoal.CreateFromString(data),
                "ChecklistGoal" => ChecklistGoal.CreateFromString(data),
                _ => null
            };

            if (goal != null) _goals.Add(goal);
        }
    }
}
