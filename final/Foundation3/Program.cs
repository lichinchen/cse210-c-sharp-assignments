public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("333 Indigo St.", "Lafayette", "IN", "47909", "USA");
        Address address2 = new Address("600 Main St.", "Lafayette", "IN", "47901", "USA");
        Address address3 = new Address("1915 Scott St.", "Lafayette", "IN", "47905", "USA");

        Event lecture = new Lecture("C# Advanced Programming", "Exploring advanced C# concepts for experienced developers", "2025-4-15", "10:00 AM", address1, "Scott Huang", 50);
        Event reception = new Reception("Spring Music Festival", "A celebration of music with live performances", "2025-4-20", "5:00 PM", address2, "godadistance@gmail.com");
        Event outdoorGathering = new OutdoorGathering("Family BBQ", "Family-friendly activities in the park", "2025-4-10", "11:00 AM", address3, "Expect sunny weather");

        Console.WriteLine("Lecture:");
        Console.WriteLine("================");
        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("--- Full Details ---");
        ((Lecture)lecture).GetLectureFullDetails();
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Reception:");
        Console.WriteLine("==================");
        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("--- Full Details ---");
        ((Reception)reception).GetReceptionsFullDetails();
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine("==========================");
        Console.WriteLine("--- Standard Details ---");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("--- Full Details ---");
        ((OutdoorGathering)outdoorGathering).GetOutdoorFullDetails();
        outdoorGathering.GetFullDetails();
        Console.WriteLine();
        Console.WriteLine("--- Short Description ---");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("------------------------------------------------");
    }
}
