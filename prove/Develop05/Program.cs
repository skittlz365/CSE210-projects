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
        // Initialize an instance of the GoalManager class to control the program
        var npManager = new GoalManager();
        string npSaveFile = "goals.txt";

        while (true)
        {
            // Set up the menu and the program loop
            Console.Clear();
            Console.WriteLine($"You have {npManager.Score} points.");
            Console.WriteLine("Menu:\n 1. Create New Goal\n 2. List Goals\n 3. Record Event\n 4. Save Goals\n 5. Load Goals\n 6. Quit");
            Console.Write("Select an option: ");
            var npChoice = Console.ReadLine();
            if (npChoice == "1")
            {
                CreateGoal(npManager);
            }
            else if (npChoice == "2")
            {
                Console.Clear();
                npManager.ListGoals();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (npChoice == "3")
            {
                Console.Clear();
                npManager.ListGoals();
                Console.Write("Select goal number to record event: ");
                if (int.TryParse(Console.ReadLine(), out int idx))
                {
                    npManager.RecordEventForGoal(idx - 1);
                }
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (npChoice == "4")
            {
                npManager.SaveToFile(npSaveFile);
                Console.WriteLine($"Saved to {npSaveFile}");
                Console.ReadLine();
            }
            else if (npChoice == "5")
            {
                npManager.LoadFromFile(npSaveFile);
                Console.WriteLine($"Loaded from {npSaveFile}");
                Console.ReadLine();
            }
            else if (npChoice == "6")
            {
                break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        // The function to create a goal within the goal manager
        Console.Clear();
        Console.WriteLine("Select goal type: 1) Simple 2) Eternal 3) Checklist");
        var t = Console.ReadLine();
        Console.Write("Name: ");
        var name = Console.ReadLine();
        Console.Write("Description: ");
        var desc = Console.ReadLine();
        Console.Write("Points per event: ");
        int.TryParse(Console.ReadLine(), out int points);

        if (t == "1")
        {
            var g = new SimpleGoal(name, desc, points);
            manager.AddGoal(g);
        }
        else if (t == "2")
        {
            var g = new EternalGoal(name, desc, points);
            manager.AddGoal(g);
        }
        else if (t == "3")
        {
            Console.Write("Target count: ");
            int.TryParse(Console.ReadLine(), out int target);
            Console.Write("Bonus points on completion: ");
            int.TryParse(Console.ReadLine(), out int bonus);
            var g = new ChecklistGoal(name, desc, points, target, bonus);
            manager.AddGoal(g);
        }
    }
}