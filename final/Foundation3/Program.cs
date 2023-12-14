using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new("Russel M. Nelson", 500);
        lectures.SetDescription("The Prophet of the Lord to address the Youth of Zion on preparing for full-time missions.");
        lectures.SetTitle("Come Listen to the Prophets Voice");
        lectures.SetDate("20 January 2024");
        lectures.SetType("Lecture");
        lectures.SetTime("18h00");

        Reception reception = new("makhehlam.mkhize@gmail.com");
        reception.SetDescription("Come join the union of Lehi and Sariah on this special day.");
        reception.SetTitle("Lehi and Sariah");
        reception.SetDate("26 February 2024");
        reception.SetType("Reception");
        reception.SetTime("10h00am");

        OutdoorGathering outdoorGathering = new("Sunny");
        outdoorGathering.SetDescription("Piano Boys live at Central park with their best hits");
        outdoorGathering.SetTitle("Piano Boys Live");
        outdoorGathering.SetDate("25 March 2024");
        outdoorGathering.SetType("Outdoor Gathering");
        outdoorGathering.SetTime("13h00");

        List<Event>eventsList = new();
        eventsList.Add(outdoorGathering);
        eventsList.Add(reception);
        eventsList.Add(lectures);

        for ( int i = 0 ; i<eventsList.Count; i++)
        {
            eventsList[i].DisplayShortDescription();
            eventsList[i].DisplayFullDetails();
            Console.WriteLine("----------------------------------------------------------");
        }



    }
}