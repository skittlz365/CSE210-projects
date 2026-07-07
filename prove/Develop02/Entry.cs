/*
This is the entry class. It stores the date, the prompt, and the
user's response as strings. There is a ToString method and a
ToCSV method that is also essentially a ToString method but saves
it in the format of a CSV.
*/
class Entry
{
    public string _npDate;
    public string _npPrompt = "";
    public string _npResponse = "";

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _npDate = theCurrentTime.ToShortDateString();
    }

    public override string ToString()
    {
        string npEntryString = $"\nDate: {_npDate}\n" + $"Prompt: {_npPrompt}\n" + $"Response: {_npResponse}";
        return npEntryString;
    }

    public string ToCSV()
    {
        string npEntryCSV = $"{_npDate}" + "|" + $"{_npPrompt}" + "|" + $"{_npResponse}";
        return npEntryCSV;
    }
}