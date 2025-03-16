using System;                     // Basic system
           
public abstract class Goal        // Base class 
{
    private string _name;         // Name of the goal
    private string _description;  // Description of the goal
    private int _points;          // Points awarded for completing the goal
    private bool _isCompleted;    // Whether the goal is completed


    public Goal(string goalName, string description, int goalPoints)  // Constructor
    {
        _name = goalName;
        _description = description;
        _points = goalPoints;
        _isCompleted = false; 
    }

    public string GetName()         // Method to get the name of the goal
    {
        return _name;
    }

    public string GetDescription()  // Method to get the description of the goal
    {
        return _description;
    }

    public int GetPoints()          // Method to retrieve the goal points
    {
        return _points;
    }

    public bool GetIsCompleted()     // Method to check if the goal is completed
    {
        return _isCompleted;
    }

    public void SetIsCompleted(bool isCompleted)  // Method to set the goal's completion status
    {
        _isCompleted = isCompleted;
    }

    public abstract void RecordEvent();  // Abstract method to handle recording an event
    public abstract string GetStatus();  // Abstract method to return goal status
    public abstract string FormatGoal(); //  Abstract method to format goal details
    public abstract Goal PartsGoal(string goalText);  // Parses goal details from a structured goal string
}