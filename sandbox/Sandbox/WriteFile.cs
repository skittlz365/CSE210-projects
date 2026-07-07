class WriteFile
{
    public void WriteJoke()
    {
        string fileName = "jokes_on_you.txt";
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            Console.Write("Enter a joke: ");
            string joke = Console.ReadLine();
            outputFile.WriteLine($"Joke: {joke}");
        }
    }
}