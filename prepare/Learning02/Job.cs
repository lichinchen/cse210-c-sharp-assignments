using System;  // For basic functionalities

public class Job  // Job class to represent a job
{
    // Public member variables for job details
    public string _company;  // Company name
    public string _jobTitle; // Job title
    public int _startYear;   // Start year of the job
    public int _endYear;     // End year of the job

    public void DisplayJobDetails()  // Method to display job details
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");  // Print job details
        
    }
}