using System;
using System.Diagnostics;
using System.Threading;

public class Activity
{
    // The base class Activity has 3 attributes: Name, Description, and Duration
    private string _npName;
    private string _npDescription;
    protected int _npDuration;

    // Create the constructor
    public Activity(string name, string description)
    {
        _npName = name;
        _npDescription = description;
    }

    // Function that shows a starting message for the activity
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_npName}.");
        Console.WriteLine();
        Console.WriteLine(_npDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string npInput = Console.ReadLine();
        if (!int.TryParse(npInput, out _npDuration) || _npDuration <= 0)
        {
            _npDuration = 30;
        }
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Function that shows an ending message for the activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_npName} for {_npDuration} seconds.");
        ShowSpinner(3);
    }

    // Function to implement a spinner
    public void ShowSpinner(int seconds)
    {
        string[] sequence = new string[] { "|", "/", "-", "\\" };
        int i = 0;
        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < seconds)
        {
            Console.Write(sequence[i % sequence.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
        sw.Stop();
        Console.WriteLine();
    }

    // Function to implement a countdown timer
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\r   \r");
        }
        Console.WriteLine();
    }

    // Getters
    public int GetDuration()
    {
        return _npDuration;
    }

    protected string GetName() => _npName;
    protected string GetDescription() => _npDescription;
}