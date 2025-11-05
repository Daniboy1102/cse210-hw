using System;

class Program
{
    static void Main(string[] args)
    {
         // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letter;
        string sign = "";

        // Determine letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // User passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time!");
        }

        // Stretch Challenge: determine + or - sign
        int lastDigit = gradePercentage % 10;

        if (letter != "F" && letter != "A") // A and F have exceptions
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && gradePercentage < 93)
        {
            // A- for 90–92
            sign = "-";
        }

        // Display letter grade
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}