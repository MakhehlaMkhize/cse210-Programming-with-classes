using System;

public class Reception: Event
{
    private string _RSVPemail;
    
    public Reception(string RSVP)
    {
        _RSVPemail = RSVP;
    }
    public override void DisplayFullDetails()
    {
        DisplayStandardDetail();
        Console.WriteLine($"Event Type: {GetType()}\nRSVP: {_RSVPemail}\n");
    }
}