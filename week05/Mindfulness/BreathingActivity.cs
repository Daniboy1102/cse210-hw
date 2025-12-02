using System;

/// <summary>
/// Guides the user through slow breathing.
/// </summary>
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by guiding you through slow breathing.") { }

    protected override void Run()
    {
        int elapsed = 0;

        while (elapsed < Duration)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4);
            elapsed += 4;

            if (elapsed >= Duration)
                break;

            Console.WriteLine("\nBreathe out...");
            Countdown(4);
            elapsed += 4;
        }
    }
}
