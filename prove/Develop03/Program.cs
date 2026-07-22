using System;
using System.Security.AccessControl;
/*
Name: Nick Parr
Class: Programming with Classes
Descritption: This program displays a scripture in the console, then when the user presses enter
it hides random words in the scripture and displays it again, and the user can keep doing this until
they type quit or all the words are hidden. It is to help users memorize scriptures.

Sources:
    1. https://byui-cse.github.io/cse210-course-2023
    2. Teacher notes...
*/
public class Program
{
    static void Main(string[] args)
    {
        // Initialize the instances of the classes
        Reference npReference = new Reference("John", 3, [16]);
        
        string npInitialScriptureText = "For God so loved the world that he gave his Only Begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture npScripture = new Scripture(npInitialScriptureText, npReference);

        string npCurrentScritpureText;

        do
        {
            // Main loop of the program, runs until the user enters quit or all the words are hidden
            Console.Clear();
            Console.WriteLine($"Reference: {npScripture.npGetReference()}");
            Console.WriteLine("Scritpure:");
            npCurrentScritpureText = npScripture.npGetScriptureText();
            Console.WriteLine($"{npCurrentScritpureText}\n");

            Console.Write("Press Enter to continue... or type 'quit' to exit.");
            string npUserInput = Console.ReadLine();

            if (string.Equals(npUserInput, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            string npNewScriptureText = Word.npHideRandomWords(npCurrentScritpureText, 3);

            bool npIsFullyHidden = !npCurrentScritpureText.Contains(" ");
            if (!npIsFullyHidden)
            {
                npScripture.npSetScriptureText(npNewScriptureText);
                npCurrentScritpureText = npNewScriptureText;
            }

        } while (npCurrentScritpureText != npInitialScriptureText && !Console.ReadLine().Equals("quit", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Program ended.");
    }
}