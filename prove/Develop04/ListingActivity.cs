using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ListingActivity : Activity
{
    // List of propmts
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor that calls the base constructor
    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    // Function to run the Listing activity
    public void Run()
    {
        DisplayStartingMessage();
        int npDuration = GetDuration();
        var npRand = new Random();
        Console.WriteLine();
        string npPrompt = _prompts[npRand.Next(_prompts.Count)];
        Console.WriteLine(npPrompt);
        Console.WriteLine();
        Console.WriteLine("You will have a few seconds to think...");
        ShowCountdown(5);
        Console.WriteLine("Start listing items (press Enter after each). Pressing Enter on empty line will continue until time runs out.");

        List<string> npEntries = new List<string>();
        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < npDuration)
        {
            Console.Write("> ");
            string line = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(line))
            {
                npEntries.Add(line.Trim());
            }
        }
        sw.Stop();

        Console.WriteLine();
        Console.WriteLine($"You listed {npEntries.Count} items.");
        DisplayEndingMessage();
    }
}