using System;  // For basic functionalities                               

class Program  // Main program class
{
    static void Main(string[] args)           // Main method, entry point of the program
    {
        Job job1 = new Job();                 // Create first Job object
        job1._jobTitle = "software Engineer"; // Set job title
        job1._company = "Microsoft";          // Set company name
        job1._startYear = 2019;               // Set start year
        job1._endYear = 2022;                 // Set end year

        //Console.WriteLine(job1._company);   // Print company name
        //job1.DisplayJobDetails();           // Display job details

        Job job2 = new Job();                 // Create second Job object
        job2._jobTitle = "software Developer";// Set job title
        job2._company = "Apple";              // Set company name
        job2._startYear = 2022;               // Set start year
        job2._endYear = 2024;                 // Set end year

        //Console.WriteLine(job2._company);   // Print company name
        //job2.DisplayJobDetails();           // Display job details

        Resume resume = new Resume();         // Create Resume object
        resume._name = "Allison Rose";        // Set resume user's name


        resume._jobs.Add(job1);               // Add first job to resume
        resume._jobs.Add(job2);               // Add second job to resume

        //Console.WriteLine(resume._jobs[0]._jobTitle); // Print first job title
        
        resume.DisplayResumeDetails();        // Display all resume details

    }
}