using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    private List<string> prompts = new()  
    {
        "Think of someone who made your day better this week.",
        "Think of a moment you laughed recently.",
        "Think of a place that brings you peace.",
        "Think of a lesson you're grateful you learned.",
        "Think of a challenge that helped you grow."
    };

    private List<string> _questions = new()
    {
        "Why are you grateful for this?",
        "How did this impact your mood?",
        "What would life be like without it?",
        "How can you express gratitude for this today?"
    };

    protected override string GetDescription()
    {
        return "This activity helps you reflect on things you're thankful for.";
    }

    protected override void Execute()
    {
        Random rand = new();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            ShowSpinner(4);
        }
    }
}