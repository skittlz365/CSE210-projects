using System;
using System.Security.AccessControl;

public class Program
{
    static void Main(string[] args)
    {
        Reference npReference = new Reference("John", 3, [16]);
        
        string npInitialScriptureText = "For God so loved the world that he gave his Only Begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture npScripture = new Scripture(npInitialScriptureText, npReference);

        string npCurrentScritpureText;

        do
        {
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