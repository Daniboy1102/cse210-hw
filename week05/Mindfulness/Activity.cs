using System;
using System.Threading;

/// <summary>
/// Base class shared by all mindfulness activities.
/// Demonstrates encapsulation (private fields) and abstraction.
/// </summary>
public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    /// <summary>
    /// Starts the activity. Calls shared start/end messages.
    /// </summary>
    public void Start()
    {
        Console.Clear();
        ShowStartMessage();
        Run();
        ShowEndMessage();
    }

    /// <summary>
    /// Displays the activity name, description, and asks for duration.
    /// </summary>
    private void ShowStartMessage()
    {
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");

        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Spinner(3);
    }

    /// <summary>
    /// Displays closing message.
    /// </summary>
    private void ShowEndMessage()
    {
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You completed {_duration} seconds of {_name}.");
        Spinner(4);
    }

    /// <summary>
    /// Simple spinner animation.
    /// </summary>
    protected void Spinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(200);
            Console.Write("\b");
            i++;
        }
    }

    /// <summary>
    /// Countdown animation.
    /// </summary>
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    /// <summary>
    /// Gives derived classes access to the duration.
    /// </summary>
    protected int Duration => _duration;

    /// <summary>
    /// Abstract method — each activity defines its own behavior.
    /// </summary>
    protected abstract void Run();
}
