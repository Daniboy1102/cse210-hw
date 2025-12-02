using System;
using System.Collections.Generic;

/// <summary>
/// Helps the user list as many positive items as possible.
/// </summary>
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Spirit this month?",
        "Who are some of your heroes?"
    };

    public ListingActivity()
        : base("Listing Activity",
               "This activity helps you reflect on the good things in your life.") { }

    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine("\nPrompt:");
        Console.WriteLine($" → {_prompts[rand.Next(_prompts.Count)]}");

        Console.WriteLine("\nYou will begin listing in...");
        Countdown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(Duration);

        Console.WriteLine("\nStart listing items. Press Enter after each:");

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
    }
}
