using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create the scripture with text
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        // Main loop – keeps going until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();                      // Clear the screen
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to stop.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")        // User wants to exit
            {
                Console.WriteLine("\nSee you next time and be blessed :)");
                break;
            }
            else
            {
                scripture.HideRandomWord(1);       // Hide random word
            }         

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words hidden. Good job!");
                break;
            }
        }

        
    }
}
