using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8), // 4.8 km
            new Cycling(new DateTime(2022, 11, 3), 45, 16.0), // 16 km
            new Swimming(new DateTime(2022, 11, 3), 60, 40) // 40 laps
        };

        // Loop through each activity and display its summary
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
