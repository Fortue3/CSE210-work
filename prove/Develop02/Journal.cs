using System;
using System.IO;

public class Journal
{
    public List <Entries> _entries = new List<Entries>();
    
    public void AddJournalEntry2()
    {
        Entries newEntry = new Entries();
        newEntry.AddJournalEntry();
        _entries.Add(newEntry);

    }

    public void DisplayJournalEntries()
    {
        foreach(Entries entry in _entries)
        {
            Console.WriteLine($"{entry._date} {entry._prompt} {entry._answer}");
        }
        
    }

     public void LoadJournal()
    {
        _entries.Clear();
        Console.WriteLine("Choose a file you like load");
        string myFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(myFile);
        
        foreach (string line in lines)
        {  
            Entries myData = new Entries();
            string[] parts = line.Split("-");
            myData._date = parts[0];
            myData._prompt = parts[1];
            myData._answer = parts[2];
            _entries.Add(myData); 
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("Choose a name for your Journal");
        string myFile =  Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(myFile))
        {
            foreach(Entries entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} -{entry._prompt} -{entry._answer}");
            }
        }

    }
    
}