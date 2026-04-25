using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string napFirstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string napLastName = Console.ReadLine();

        Console.WriteLine("");

        string napAgentName = napLastName + ", " + napFirstName + " " + napLastName + ".";
        Console.WriteLine($"Your name is {napAgentName}");
    }
}