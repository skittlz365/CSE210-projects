using System;
using System.Collections.Generic;
using System.Diagnostics;

public class ReflectingActivity : Activity
{
    // Lists for prompts and questions
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor that calls the base constructor
    public ReflectingActivity() : base("Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    { }

    // Function to run the Reflecting activity
    public void Run()
    {
        DisplayStartingMessage();
        int npDuration = GetDuration();
        var npRand = new Random();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- { _prompts[npRand.Next(_prompts.Count)] } ---");
        Console.WriteLine();

        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < npDuration)
        {
            string q = _questions[npRand.Next(_questions.Count)];
            Console.WriteLine(q);
            ShowSpinner(5);
        }
        sw.Stop();
        DisplayEndingMessage();
    }
}