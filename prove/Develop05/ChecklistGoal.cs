using System;                      // Basic system

public class ChecklistGoal : Goal  // Inherits from Goal class
{
    private int _targetCount;     // The number of times wanted to complete the goal
    private int _currentCount;    // The current progress count
    private int _bonusPoints;     // Extra points as goal is completed
   
    // Constructor
    public ChecklistGoal(string goalName, string description, int goalPoints, int targetCount, int bonusPoints, int currentCount)
        : base(goalName, description, goalPoints)  
    {
        // Initialize
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
       
    }

    public int GetBonusPoints()  // Get the bonus points
    {
        return _bonusPoints;
    }
    
    public int GetTargetCount()  // Get the target count
    {
        return _targetCount;
    }

    public int CountTotalPoints()
    {
        if (_currentCount >= _targetCount)
        {
            return (GetPoints() * _targetCount) + _bonusPoints;   // Total if completed
        }
        else
        {
            return GetPoints() * _currentCount;                   // Total for current progress
        }
    }

    public override void RecordEvent()                            // Record event
    {
        if (_currentCount < _targetCount)                         // Check if goal is incomplete
        {
            _currentCount++;                                      // Increase current count
            Console.WriteLine($"{GetName()} -- Goal recorded!");  // Show progress
            Console.WriteLine($"Progress: {_currentCount}/{_targetCount}.");
            Console.WriteLine($"You earned {CountTotalPoints()} points.");
        }
        
        if (_currentCount >= _targetCount)                         // Check if target count is reached
        {
            SetIsCompleted(true);                                  // Mark as completed when target count is reached
            Console.WriteLine($"\nCongratulations!");              // Show completion message
            Console.WriteLine($"You completed -- {GetName()} -- ");
            Console.WriteLine($"You earned a bonus of {_bonusPoints} points!");
            Console.WriteLine($"Total points earned: {CountTotalPoints()}");
        }
    }




    public override string GetStatus()  // display goal status
    {
        if (GetIsCompleted())           // If the goal is completed
        {
            string completeStatus = $"[x] {GetName()} --- ({GetDescription()}) ---{CountTotalPoints()} points--- (Completed {_targetCount}/{_targetCount})";
            return completeStatus;
        }
        else                            // If the goal is incompleted
        {
            string inProgressStatus = $"[ ] {GetName()} --- ({GetDescription()}) ---{CountTotalPoints()} points--- (Currently completed {_currentCount}/{_targetCount})";
            return inProgressStatus;
        }
       
    }
    

    public override string FormatGoal()  // Overriding method to format ChecklistGoal details
    {
        return $"ChecklistGoal: {GetName()} | {GetDescription()} | {GetPoints()} | {_targetCount} | {_bonusPoints} | {_currentCount}";
    }

    public override Goal PartsGoal(string goalText)
    {
        string[] parts = goalText.Split('|');                                                        // Split by '|'
        string name = parts[0].Trim();                                                               // Get goal name
        string description = parts[1].Trim();                                                        // Get description
        int points = int.Parse(parts[2].Trim());                                                     // Convert points to integer
        int targetCount = int.Parse(parts[3].Trim());                                                // Determine if the goal is complete 
        int bonusPoints = int.Parse(parts[4].Trim());                                                // Convert  bonus points to integer
        int currentCount = int.Parse(parts[5].Trim());                                               // current count
        ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints, currentCount); // Create goal
        return goal;                                                                                 // Return goal
    }
}