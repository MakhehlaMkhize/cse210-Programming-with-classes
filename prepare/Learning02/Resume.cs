using System;
using System.Security.Cryptography.X509Certificates;

public class Resume
{
    public string _personsName;
    public List<Job>_jobList = new List<Job>();

    public void DisplayAllJobDetails()
    {
        Console.WriteLine($"Name: {_personsName}");
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobList)
        {
            job.DisplayJobDetails();
        }
        
    }

}