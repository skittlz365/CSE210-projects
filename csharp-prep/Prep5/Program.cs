using System;

class Program
{
    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName; 
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int userNumberInt = int.Parse(userNumber);
        return userNumberInt;
    }

    static int PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter your birth year: ");
        string birthYearStr = Console.ReadLine();
        birthYear = int.Parse(birthYearStr);
        return birthYear;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"{name}, the square of your number is {number}.");
        int age = 2026 - year;
        Console.WriteLine($"{name}, you will turn {age} this year");
    }
    static void Main(string[] args)
    {
        WelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(userName, squareNumber, birthYear);
    }

}