// ScriptureMemorizer Project
// Creative feature: User can choose between two example scriptures to memorize.
// This makes the program more interactive and helpful for practice.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a scripture to memorize:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. John 3:16");
        Console.Write("Enter 1 or 2: ");
        string choice = Console.ReadLine();

        Reference reference;
        string text;
        if (choice == "2")
        {
            reference = new Reference("John", 3, 16);
            text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        }
        else
        {
            reference = new Reference("Proverbs", 3, 5, 6);
            text = "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3); // Hide 3 words each time
            }
            else
            {
                // Show final display and end
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Play again later!");
                break;
            }
        }
    }
}