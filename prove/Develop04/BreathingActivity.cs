using System;
using System.Threading;

public class BreathingActivity : Activity
{
    private int _inhaleTime;   // Time to inhale
    private int _exhaleTime;   // Time to exhale
    private int _prepareTime;  // Preparation time
    private int _totalCycles;  // Calculated total cycles

    // Constructor
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _inhaleTime = 7;   // Default inhale time (7 sec)
        _exhaleTime = 7;   // Default exhale time (7 sec)
        _prepareTime = 5;  // Default preparation time (5 sec)
    }

    // Start breathing cycles
    public void RunBreathingCycle()
    {
        // Calculate the total number of cycles
        _totalCycles = (GetDuration() - _prepareTime) / (_inhaleTime + _exhaleTime);

        Console.Clear();
        Console.WriteLine($"You will do {_totalCycles} Breathing Cycles.");
        Console.WriteLine("\nGet ready...");
        Console.WriteLine($"\nStarting this session in {_prepareTime} seconds.");
        DisplayAnimation(_prepareTime);        // Preparation time: 5 seconds

        for (int i = 0; i < _totalCycles; i++)
        {
            Console.WriteLine($"\nCycle {i + 1} of {_totalCycles}:");  // Display the current cycle number
            Console.WriteLine("\nInhale...");
            DisplayAnimation(_inhaleTime);     // Inhale for 7 seconds

            Console.WriteLine("\nExhale...");
            DisplayAnimation(_exhaleTime);     // Exhale for 7 seconds
        }
        Console.WriteLine("\nBreathing cycle completed!");
    }

    // Execute breathing activity
    public void ExecuteBreathingActivity()
    {
        ExecuteStartActivity();      // Inherited method  
        RunBreathingCycle();         // Start breathing cycle (the main part)
        ExecuteEndActivity();        // Inherited method
    }
}
