using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;  

    public void Run()
    {
        ShowStartMessage();
        PrepareToBegin();
        Execute();
        ShowEndMessage();
    }

    protected void ShowStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {GetType().Name}...");
        Console.WriteLine(GetDescription());
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());  // No error handling
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected void ShowEndMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You completed the {GetType().Name} for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    protected abstract string GetDescription();
    protected abstract void Execute();
}