using System;
/*
Name: Nick Parr
Class: Programming with Classes
Descritption: This program is meant to help with mindfulness, by having users select from 3 different
mindfulness activities, Breathing, Reflecting, and Listing. Each of the activity classes inherit
from a base Activity class, and they each handle their own implementation. 

Sources:
    1. https://byui-cse.github.io/cse210-course-2023
    2. Teacher notes...
*/
class Program
{
    static void Main(string[] args)
    {
        // Initialize the main loop of the program that handles the menu
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string npChoice = Console.ReadLine();

            if (npChoice == "1")
            {
                // Initialize a new instance of BreathingActivity and run it
                var a = new BreathingActivity();
                a.Run();
            }
            else if (npChoice == "2")
            {
                // Initialize a new instance of ReflectingActivity and run it
                var a = new ReflectingActivity();
                a.Run();
            }
            else if (npChoice == "3")
            {
                // Initialize a new instance of ListingActivity and run it
                var a = new ListingActivity();
                a.Run();
            }
            else if (npChoice == "4")
            {
                // Exit the program
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
            }

            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}