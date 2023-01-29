using System.Collections.Generic;
using System.IO;
using System;
public class JournalEntries
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entryNew)
    {
        _entries.Add(entryNew);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine("");
            }
    }
    public void SaveJournal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}:{entry._promptQuestion}:{entry._userText}");
            }
        }
    }
    public void JournalLoad(string filename)
    {
        _entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename); //used from the example code
        foreach (string line in lines)
        {
            string [] parts = line.Split(":");
            Entry newEntryParts = new Entry();
            newEntryParts._date = parts[0];
            newEntryParts._promptQuestion = parts[1];
            newEntryParts._userText = parts[2];
            _entries.Add(newEntryParts);

        }
    }
    public void RemoveEntryFromJournal(int removeIndex)
    {
        int correctRemoveIndex = removeIndex - 1;
        _entries.RemoveAt(correctRemoveIndex);
    }
}