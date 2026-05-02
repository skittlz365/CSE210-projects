using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Enter 0 when finished.");

        bool flag = true;
        while(flag == true)
        {
            Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            int numberInt = int.Parse(numberStr);

            if(numberInt > 0)
            {
                numbers.Add(numberInt);
            }

            else if(numberInt < 0)
            {
                numbers.Add(numberInt);
            }

            else
            {
                flag = false;
            }
        }
        int count = numbers.Count;
        int sum = 0;
        int greatestNum = 0;
        int smallestPosNum = 999999;
        foreach(int number in numbers)
        {
            sum += number;
            if(number > greatestNum)
            {
                greatestNum = number;
            }
            else if(number < smallestPosNum && number > 0)
            {
                smallestPosNum = number;
            }
        }

        Console.WriteLine($"The sum is {sum}");

        int average = sum / count;
        Console.WriteLine($"The average is {average}");

        Console.WriteLine($"The greatest number is {greatestNum}");
        Console.WriteLine($"The smallest positive number is {smallestPosNum}");
        
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}