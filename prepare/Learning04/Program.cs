using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment npAssignment = new Assignment("Nick", "English");
        string npSummary = npAssignment.npGetSummary();
        Console.WriteLine(npSummary);

        MathAssignment npMathAssignment = new MathAssignment("Nick", "Fractions", "5.2", "3-12");
        string npSummary2 = npMathAssignment.npGetSummary();
        string npProblemsList = npMathAssignment.GetHomeworkList();
        Console.WriteLine(npSummary2);
        Console.WriteLine(npProblemsList);

        WritingAssignment npWritingAssignment = new WritingAssignment("Nick", "Argumentative Essay", "Why Insurance is a Scam");
        Console.WriteLine(npWritingAssignment.npGetSummary());
        Console.WriteLine(npWritingAssignment.npGetWritingInformation());
    }
}