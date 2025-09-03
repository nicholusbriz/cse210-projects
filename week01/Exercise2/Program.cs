using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade percentage? ");
        string percentage = Console.ReadLine();
        float grade = float.Parse(percentage);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = (int)grade % 10;

        if (letter != "F") 
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

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        Console.WriteLine($"Your Grade is {letter}{sign}");

        // pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("🎉 Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("💡 Don't give up! Retake the course—you've got this.");
        }
    }
}
