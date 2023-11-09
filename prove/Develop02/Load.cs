using System;

public class Load
{
    public string[] _savedEntries;
    
    public void LoadSaveJournalEntries(string fileName, List<string>savedEntries )
    {
        string[] journalEntries = System.IO.File.ReadAllLines(fileName);
        
        foreach(string journalEntry in journalEntries)
        {
            _savedEntries = journalEntry.Split("\n\n");
            
            foreach (string entry in _savedEntries)
            {
                savedEntries.Add(entry);
            }
        }
        Console.WriteLine("Journal Entries have been loaded.");
        }

        
       
    
    
}