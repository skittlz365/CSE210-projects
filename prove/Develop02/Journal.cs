using System.Collections.Generic;

class Journal
{
    /* These 2 lists are to keep track of the entries that are created in the main program,
    one is strings, to make the saving easier, and one is the actual entry type */
    public List<string> _npEntriesStr = new List<string>();
    public List<Entry> _npEntries = new List<Entry>();

/* This function adds an entry to the lists above, one as a string and the other as an entry */
    public void AddEntry(Entry npEntry)
    {
        _npEntries.Add(npEntry);
        _npEntriesStr.Add(npEntry.ToString());
    }

/* This function clears both lists of entries in order to load a previous journal */
    public void ClearEntries()
    {
        _npEntries.Clear();
        _npEntriesStr.Clear();
    }

/* This function is to save the entry lists to a file */
    public override string ToString()
    {
        string npJournalOutput = "";

        foreach (Entry npEntry in _npEntries)
        {
            npJournalOutput += npEntry.ToCSV() + "\n";
        }

        return npJournalOutput;
    }
}

