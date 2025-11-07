using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Method to display resume information
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Display each job in the list
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
