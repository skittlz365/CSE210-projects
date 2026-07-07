using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

/*
Name: Nick Parr
Class: Programming with Classes (CSE 210)
Description: The journal program is a program that allows you to write responses
to prompts and save them to a file, then later display your journal.
Sources:
1. https://byui-cse.github.io/cse210-course-2023
2. Teacher notes
3. Internet research
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        string npMenuMessage = "1: Write" + "\n2: Display" + 
        "\n3: Load" + "\n4: Save" + "\n5: Quit" + "\nWhat would you like to do? ";

        bool npQuitFlag = false;

        // Initialize the journal and prompt classes here
        Journal myJournal = new Journal();
        Prompt myPrompt = new Prompt();

        // The main program loop, will run until the user enters 5
        while (npQuitFlag == false)
        {
            Console.Write(npMenuMessage);
            string npUserChoice = Console.ReadLine();

            /* This option provides a prompt and saves the response of the user
            to the journal class */
            if (npUserChoice == "1")
            {
                /* The entry class has to be initialized here so that each time
                the user writes a response it will be a new entry stored in the
                journal, and not overwrite the previous entry */
                Entry myEntry = new Entry();
                myPrompt._npPrompt = myPrompt.GeneratePrompt();
                Console.WriteLine(myPrompt._npPrompt);
                myEntry._npResponse = Console.ReadLine();
                myEntry._npPrompt = myPrompt._npPrompt;
                myJournal.AddEntry(myEntry);
            }

            /* This option writes the response from each prompt in the journal
            to the console for the user */
            else if (npUserChoice == "2")
            {
                foreach (string entry in myJournal._npEntriesStr)
                {
                    Console.WriteLine(entry);
                }
            }

            /* This option loads a journal previously saved to a file and replaces
            the current data in the journal class with the entries from the file */
            else if (npUserChoice == "3")
            {
                Console.Write("\nWhat is the file name? ");
                string npFileName = Console.ReadLine();
                Entry myEntry2 = new Entry();
                LoadJournal(npFileName, myJournal);
            }

            /* This option saves the data currently stored in the journal class to
            a file that can be accessed later */
            else if (npUserChoice == "4")
            {
                Console.Write("\nWhat is the file name? ");
                string npFileName = Console.ReadLine();
                SaveJournal(npFileName, myJournal);
            }

            /* This option sets npQuitFlag to be true so that the loop will end and
            the program will be over */
            else
            {
                Console.WriteLine("\nThank you for using the Journal Program!");
                npQuitFlag = true;
            }
        }
    }

    /* The function LoadJournal() takes in the file name entered by the user
    and the name of the journal class being used in the program, replaces the
    old entries using .ClearEntries() and loads the entries stored in the file
    using a foreach loop. */
    static void LoadJournal(string npFileName, Journal npJournalName)
    {
        npJournalName.ClearEntries();
        string[] npJournal = System.IO.File.ReadAllLines(npFileName);
        
        foreach (string npLine in npJournal)
        {
            if(npLine.Trim() == "")
            {
                break;
            }

            string[] npEntries = npLine.Split("|");
            Entry npEntry = new Entry();

            npEntry._npDate = npEntries[0];
            npEntry._npPrompt = npEntries[1];
            npEntry._npResponse = npEntries[2];
            npJournalName.AddEntry(npEntry);
        }
    }

    /* The function SaveJournal takes in the file name entered by the
    user, and the name of the journal class storing the data, and uses
    the .ToString() method in order to save the entries to a file. */
    static void SaveJournal(string npFileName, Journal npJournalName)
    {
        using (StreamWriter outputFile = new StreamWriter(npFileName))
        {
            outputFile.WriteLine(npJournalName.ToString());
        }
    }
}

