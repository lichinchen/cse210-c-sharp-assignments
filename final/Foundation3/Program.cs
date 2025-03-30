using System;  // Import system namespace

// Creates Address objects
// Creates three event objects
// Prints details for each event

public class Program
{
    // Program execution begins here
    public static void Main(string[] args)
    {
        // Create address objects for three locations
        Address address1 = new Address("333 Indigo St.", "Lafayette", "IN", "47909", "USA");
        Address address2 = new Address("600 Main St.", "Lafayette", "IN", "47901", "USA");
        Address address3 = new Address("1915 Scott St.", "Lafayette", "IN", "47905", "USA");

        // Create events for Lecture, Reception, and Outdoor Gathering
        Lecture lecture = new Lecture("C# Advanced Programming", "Exploring advanced C# concepts for experienced developers", "2025-4-15", "10:00 AM", address1, "lecture", "Scott Huang", 50);
        Reception reception = new Reception("Spring Music Festival", "A celebration of music with live performances", "2025-4-20", "5:00 PM", address2, "reception", "godadistance@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Family BBQ", "Family-friendly activities in the park", "2025-4-10", "11:00 AM", address3, "outdoorGathering", "Expect sunny weather");

        // Print details for the Lecture, including standard details, full details, short description
        Console.WriteLine("Lecture:");
        Console.WriteLine("================\n");
        Console.WriteLine($"--- Standard Details ---\n\n{lecture.GetStandardDetails()}\n");
        Console.WriteLine($"--- Full Details ---\n");
        lecture.GetLectureFullDetails();
        Console.WriteLine($"\n--- Short Description ---\n\n{lecture.GetShortDescription()}");
        Console.WriteLine("------------------------------------------------\n");
        
        // Print details for the Reception, including standard details, full details, short description
        Console.WriteLine("Reception:");
        Console.WriteLine("==================\n");
        Console.WriteLine($"--- Standard Details ---\n\n{reception.GetStandardDetails()}\n");
        Console.WriteLine($"--- Full Details ---\n");
        reception.GetReceptionsFullDetails();
        Console.WriteLine($"\n--- Short Description ---\n\n{reception.GetShortDescription()}");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

        // Print details for the Outdoor Gathering, including standard details, full details, short description
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine("==========================\n");
        Console.WriteLine($"--- Standard Details ---\n\n{outdoorGathering.GetStandardDetails()}\n");
        Console.WriteLine($"--- Full Details ---\n");
        outdoorGathering.GetOutdoorFullDetails();
        Console.WriteLine($"\n--- Short Description ---\n\n{outdoorGathering.GetShortDescription()}");
        Console.WriteLine("------------------------------------------------");
    }
}

