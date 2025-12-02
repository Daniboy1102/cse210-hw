using System;
using System.Collections.Generic;

/// <summary>
/// Helps the user reflect deeply on meaningful experiences.
/// </summary>
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel afterward?",
        "What did you learn from this experience?",
        "How could this help you in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times of strength and resilience.") { }

    protected override void Run()
    {
        Random rand = new Random();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine($" → {_prompts[rand.Next(_prompts.Count)]}");
        Console.WriteLine("\nReflect on the following questions:\n");

        int elapsed = 0;

        while (elapsed < Duration)
        {
            string q = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("> " + q);

            Spinner(4);
            elapsed += 4;
        }
    }
}
