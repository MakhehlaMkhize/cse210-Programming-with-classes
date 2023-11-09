using System;

class Display
{
  public List<string> _listOfJournalEntries = new();
  
  public void DisplayJournalEntries()
  {
    
    foreach (string entry in _listOfJournalEntries)
    {
      Console.WriteLine(entry);
    }
    if ( _listOfJournalEntries.Count == 0)
    {
      Console.WriteLine("\nYou do not have any entries in your journal.\n");
    }
  }
}