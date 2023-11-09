using System;

public class Save
{   
    public List<string> _entries = new();
    
    public void SaveJournalEntries(string fileName, List<string>journalEntries)
    {
        using (StreamWriter saveJournal = new(fileName))
        {
            foreach ( string entry in journalEntries)
            {
                saveJournal.WriteLine(entry);
            }
            
        }
        Console.WriteLine("Your file has been saved.");       
    }


}