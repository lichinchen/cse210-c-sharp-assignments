using System;  // For basic functionalities
using System.Collections.Generic;  // For List class


public class Resume                          // Resume class
{
    public string _name;                     // Name of the person
    public List<Job>_jobs = new List<Job>(); // List of jobs

    public void DisplayResumeDetails()       // Display resume details
    {
        Console.WriteLine($"Name: {_name}"); // Print name
        Console.WriteLine("Jobs: ");         // Print job header

        foreach (var detail in _jobs)        // Loop through jobs
        {
            detail.DisplayJobDetails();      // Print job details
        }

    }

}