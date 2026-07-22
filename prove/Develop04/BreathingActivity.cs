using System;
using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    // There are no attributes other than those inherited from Activity

    // Constructor that calls the base constructor
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    // Function to run the breathing activity
    public void Run()
    {
        DisplayStartingMessage();
        int npDuration = GetDuration();
        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < npDuration)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
        }
        sw.Stop();
        DisplayEndingMessage();
    }
}