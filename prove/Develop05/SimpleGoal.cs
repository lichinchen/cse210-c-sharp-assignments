using System;                   // Basic system

public class SimpleGoal : Goal  // Inherits from Goal class
{
    public SimpleGoal(string goalName, string description, int goalPoints) 
        : base(goalName, description, goalPoints)   
    {
        // Constructor calls base class constructor
    }

    public override void RecordEvent()      // Override method to record event completion
    {
        // Check if the goal is already completed to stop it from being completed again
        if (!GetIsCompleted())              // Check if the goal is incomplete
        {
            SetIsCompleted(true);           // Mark as completed
            //_oneTimePoints = GetPoints();   // Set the points to the one-time points
            Console.WriteLine($"{GetName()} -- Goal completed! You earned {GetPoints()} points.");  // Show completion message
        }
        else
        {
            Console.WriteLine($"{GetName()} -- Goal is already completed!");  // Inform the goal is already completed
        }
    }

    public override string GetStatus()  // Override method to display goal status
    {
        if (GetIsCompleted())           // Check if the goal is completed
        {
            return $"[x] {GetName()} --- ({GetDescription()}) --- {GetPoints()} points";  // Return completed status
        }
        else
        {
            return $"[ ] {GetName()} --- ({GetDescription()}) --- 0 points";                  // Return incomplete status
        }
    }

    public override string FormatGoal()                                                       // Formats details of SimpleGoal
    {
        return $"SimpleGoal: {GetName()} | {GetDescription()} | {GetPoints()} | {GetIsCompleted()}";
    }

    public override Goal PartsGoal(string goalText)
    {
        string[] parts = goalText.Split('|');                               // Split by '|'
        string name = parts[0].Trim();                                      // Get goal name
        string description = parts[1].Trim();                               // Get description
        int points = int.Parse(parts[2].Trim());                            // Convert points to integer
        bool isCompleted = bool.Parse(parts[3].Trim());                     // Determine if the goal is complete 
    
        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);  // Create goal
        simpleGoal.SetIsCompleted(isCompleted);                             // Update the goal’s completion status
        return simpleGoal;                                                  // Return goal
    }

}