using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2025-4-03", 30, 3.0),
            new Cycling("2025-5-03", 30, 15.0),
            new Swimming("2025-6-03", 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
