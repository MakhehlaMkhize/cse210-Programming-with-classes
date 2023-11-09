using System;

public class Write
{
    public string[] _journalPrompts;
    public string _selectedPrompt;
    public string _journalEntry;

    public void Entry()
    {
        _journalPrompts = new string[] {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "If I had one thing I could do over today, what would it be?", "What did you work on today?", "What work did you accomplish today that you are most proud of?", "What drained you today?", "What gave you energy today?", "When was the last time you said, 'thank you' to a coworker?","What are you most worried about?", "What is something you learned today?"};

        Random randomPromptSelection = new();

        int promptIndexSelector = randomPromptSelection.Next(_journalPrompts.Length);

        _selectedPrompt = _journalPrompts[promptIndexSelector];

        Console.WriteLine(_selectedPrompt);

        _journalEntry = Console.ReadLine();
    }
}