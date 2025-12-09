using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals(); // Load previous goals if any
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n************ MENU *************");
            Console.WriteLine("| 1-Create Goal               |");
            Console.WriteLine("| 2-Record Event              | ");
            Console.WriteLine("| 3-Show Goals                |");
            Console.WriteLine("| 4-Save & Exit               |");
            Console.WriteLine("*******************************\n\n");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();  // Add new goal
                    break;
                case "2":
                    manager.RecordEvent(); // Record event for a goal
                    break;
                case "3":
                    manager.ShowGoals();   // Display all goals
                    break;
                case "4":
                    manager.SaveGoals();   // Save goals and exit
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
