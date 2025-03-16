using System;                    // Import System

public class EternalGoal : Goal  // Inherits from Goal class
{
    private int _count;          // Record how many times the goal was completed
    private int _totalPoints;    // Track total accumulated points
    public EternalGoal(string goalName, string description, int goalPoints) 
        : base(goalName, description, goalPoints)  // Constructor calls base class constructor
    {
       // Initialize
        _count = 0;
        _totalPoints = 0;
    }

    public int GetCount()              // Returns the completion count of the goal.
    {
        return _count;  
    }

    public void AccumulatePoints()
    {
        _totalPoints += GetPoints();   // Add points per event
    }

                               
    public int GetTotalPoints()        // returns the total accumulated points
    {
        return _totalPoints;
    }

    public override void RecordEvent()  // Record each event
    {
       _count ++;
       AccumulatePoints();              // Add points per event

       Console.WriteLine($"{GetName()} -- Goal recorded!");
       Console.WriteLine($"Eternal goals never complete, earn points each time");
       Console.WriteLine($"You earned {GetPoints()} points.");
       Console.WriteLine($"Done: {GetCount()} times -- Keep Going!");
    }



    public override string GetStatus()  // Override method to display goal status
    {
        return $"[ ] {GetName()} --- ({GetDescription()}) --- {GetTotalPoints()} points --- Done: {GetCount()} times";
    }

    public override string FormatGoal()  // Overriding method to format EternalGoal details
    {
        return $"EternalGoal: {GetName()} | {GetDescription()} | {GetPoints()} | {GetTotalPoints()} | {GetCount()}";
        
    }

    public override Goal PartsGoal(string goalText)
    {
        string[] parts = goalText.Split('|');                           // Split by '|'
        string name = parts[0].Trim();                                  // Goal name
        string description = parts[1].Trim();                           // Goal description
        int points = int.Parse(parts[2].Trim());                        // Points
        int totalPoints = int.Parse(parts[3].Trim());                   // Total accumulated points
        int count = int.Parse(parts[4].Trim());                         // Completion count
        EternalGoal goal = new EternalGoal(name, description, points);  // Create goal
        return goal;                                                    // Return goal
    }

}