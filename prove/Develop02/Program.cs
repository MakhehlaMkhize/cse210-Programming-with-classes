using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        UserSelection userAction = new();
        Write write = new();
        Display displayEntries = new();
        Load loadEntries = new();
        Save saveEntries = new();
        DateTime currentDate = DateTime.Now;

        do{
            try
            {
                userAction.DisplaySelection();
                if (userAction._userSelection == 1)
                {
                    write.Entry();
                    displayEntries._listOfJournalEntries.Add($"Date: {currentDate.ToString("d")} -Prompt: {write._selectedPrompt}\n{write._journalEntry}\n\n");
                }
                else if (userAction._userSelection == 2)
                {
                    displayEntries.DisplayJournalEntries();
                }
                else if (userAction._userSelection == 3)
                {
                    Console.WriteLine("What is the name of the file?");
                    string fileName = Console.ReadLine();
                    loadEntries.LoadSaveJournalEntries(fileName,displayEntries._listOfJournalEntries);
                }
                else if (userAction._userSelection == 4)
                {
                    Console.WriteLine("What would you like to save the file as?");
                    string fileName = Console.ReadLine();
                    saveEntries.SaveJournalEntries(fileName,displayEntries._listOfJournalEntries);
                }
                else if ( userAction._userSelection == 5)
                {
                    Console.WriteLine("Journal closed. See you next time.");
                }
                else
                {
                    Console.WriteLine("\nPlease make a correct selection.\n");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("\nPlease make a selection between 1-5.\n");
            }  
        }while (userAction._userSelection !=5 );
    }
}