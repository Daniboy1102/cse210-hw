using System;
using System.Collections.Generic;
using System.IO;

// ===============================================
// CLASS: Entry
// Stores one journal entry: date, prompt, and response
// ===============================================
class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}\n");
    }
}

// ===============================================
// CLASS: PromptGenerator
// Provides random prompts
// ===============================================
class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}

// ===============================================
// CLASS: Journal
// Holds all entries and manages saving/loading
// ===============================================
class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to show yet.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}|{e._promptText}|{e._entryText}");
            }
        }
        Console.WriteLine("Journal saved!\n");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length >= 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
        }

        Console.WriteLine("Journal loaded!\n");
    }
}

// ===============================================
// CLASS: Program
// Main menu and interaction
// ===============================================
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry
                    {
                        _date = DateTime.Now.ToShortDateString(),
                        _promptText = prompt,
                        _entryText = response
                    };

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added!\n");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load (e.g., journal.txt): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.\n");
                    break;
            }
        }
    }
}
