using System;
using System.IO;

class ReadFile
{
    public void ReadJoke()
    {
        string fileName = "jokes_on_you.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}