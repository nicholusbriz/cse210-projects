using System;
using System.Threading;

public class BreathingActivity : Activity
{
    protected override string GetDescription()
    {
        return "This activity will help you relax by guiding you through slow breathing.";
    }

    protected override void Execute()
    {
        DateTime end = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < end)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);  
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}