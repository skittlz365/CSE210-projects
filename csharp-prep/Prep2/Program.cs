using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string napPercentage = Console.ReadLine();

        char napLetterGrade = 'A';
        int napPercentageNumber = int.Parse(napPercentage);

        if(napPercentageNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }

        else
        {
            Console.WriteLine("Looks like you didn't pass the class. Better luck next time!");
        }

        if (napPercentageNumber >= 90)
        {
            napLetterGrade = 'A';
        }
        
        else if(napPercentageNumber >= 80)
        {
            napLetterGrade = 'B';
        }

        else if(napPercentageNumber >= 70)
        {
            napLetterGrade = 'C';
        }

        else if(napPercentageNumber >= 60)
        {
            napLetterGrade = 'D';
        }

        else
        {
            napLetterGrade = 'F';
        }
        
        int napPercentageRemainder = napPercentageNumber % 10;
        char napPlusOrMinus;

        if(napPercentageRemainder >= 7 && napPercentageNumber <= 93 && napPercentageNumber >= 60)
        {
            napPlusOrMinus = '+';
        }

        else if(napPercentageRemainder <= 3 && napPercentageNumber <= 93 && napPercentageNumber >= 60)
        {
            napPlusOrMinus = '-';
        }

        else
        {
            napPlusOrMinus = ' ';
        }

        Console.WriteLine($"Your grade is {napLetterGrade}{napPlusOrMinus}");
    }
}