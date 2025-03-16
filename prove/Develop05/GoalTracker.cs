using System;                       // Basic system 
using System.Collections.Generic;   // For list
using System.IO;                    // For file input/output

public class GoalTracker            // Class that manages goals
{
    private List<Goal> _goals;      // List to store goals
    private int _totalScore;        // User's total score

    public GoalTracker()            // Constructor
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public int GetTotalScore()      // get the total score
    {
        return _totalScore;
    }

    public void AllRecordEvent()       // record a goal event
    {
        Console.WriteLine("The goals are: ");                        // Displays available goals

        for (int i = 0; i < _goals.Count; i++)                       // Loops through the list of goals
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");    // Displays each goal's name
        }

        Console.Write("\nWhich goal did you accomplish? (Enter the number of the goal):  ");  // Prompt for user input
        string input = Console.ReadLine();                                                    // Gets user input
        int numberGoal = int.Parse(input);                                                    // Converts input to an integer
        Goal chosenGoal = _goals[numberGoal - 1];                                             // It subtracts 1 because list indices are zero-based, but the user input is one-based.
        
        if (chosenGoal.GetIsCompleted())                                                      // Check if the goal is completed; if so, no points are awarded. 
        {
            Console.WriteLine($"{chosenGoal.GetName()} -- Goal is already completed!");
            Console.WriteLine("This time you earned 0 points!");
            Console.WriteLine("Please choose another goal to do.");
            return;
        }

        chosenGoal.RecordEvent();                                                             // Records the event for the selected goal

        int pointsGet = chosenGoal.GetPoints();                                               // Gets points for the selected goal
        int bonusPoints = 0;                                                                  // Initialize bonus points 0

        if (chosenGoal is ChecklistGoal checklistGoal)                                        // Check if the chosen goal is a ChecklistGoal
        {
            if (checklistGoal.GetIsCompleted())                                               // Check if the checklist goal is completed                                
            {
                bonusPoints = checklistGoal.GetBonusPoints();                                 // Get the bonus points 
            }
        }

        int totalPoints = pointsGet + bonusPoints;                                            // total points by adding the base points (pointsGet) and bonus points
        _totalScore += totalPoints;                                                           // Updates the total score

        //if (chosenGoal is EternalGoal eternalGoal)
        //{
        //    eternalGoal.AccumulatePoints();                                                   // Accumulate points for EternalGoal
        //}
                                                                    
        Console.WriteLine($"\nCongratulations!");                                             // Display completion message                                          
        Console.WriteLine($"This time you earned {pointsGet} points!");                       // Show points earned
        Console.WriteLine($"You now have total {_totalScore} points.");                       // Display updated total score
    }
    
    public void DisplayGoals()                                                                // display all goals and scores
    {
        if (_goals.Count == 0)                                                                // Checks if goals exist
        {
            Console.WriteLine("No goals have been created yet.");                             // Displays message if no goals
            return;
        }

        
        for (int i = 0; i < _goals.Count; i++)                                                // Loops through the goals
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");                           // Displays goal status
        }
        Console.WriteLine("\nAll Goal Total Score: " + _totalScore);                          // Displays the total score of all goals
    }

    public void AddGoal(Goal goal)                                                            // add a new goal
    {
        _goals.Add(goal);                                                                     // Adds the goal to the list
        Console.WriteLine($"\nGoal --{goal.GetName()}-- has been added!");                    // Confirms goal added
    }


    public void SaveGoals()                                                                  // Method to save goals to a file
    {
        Console.Write("What is the filename (With .txt): ");                                 // Prompt for filename
        string filename = Console.ReadLine();                                                // Gets user input for filename

        using (StreamWriter writer = new StreamWriter(filename))                             // Opens the file for writing
        {
            writer.WriteLine(GetTotalScore());                    // Writes the total score to the file
        }
        
        using (StreamWriter writer = File.AppendText(filename))                              // Open file in append mode
        {
            foreach (Goal goal in _goals)                                                    // Loop through each goal in the list
            {
                writer.WriteLine(goal.FormatGoal());                                         // Save goal details to the file
            }
        }
        Console.WriteLine("Goals saved successfully.");                                      // Confirm goals are saved

    }
       

    public void LoadGoals()                                                                  // load goals from a file
    {
        Console.Write("What is the filename (With .txt): ");                                 // Prompt user for filename
        string filename = Console.ReadLine().Trim();                                         // Read and trim user input 
    
        Console.WriteLine("\nLoaded goals...");                                              // Display message before loading
    
        if (File.Exists(filename))                                                           // Check if the file exists
        {
            _goals.Clear();                                                                  // Clear existing goals before loading new ones
            
            string[] lines = File.ReadAllLines(filename);                                    // Read file lines into an array

            int totalPoints = int.Parse(lines[0].Trim());                                    // Parse the first line as total points
            _totalScore = totalPoints;                                                       // Set the total score in goalTracker
            Console.WriteLine($"You have {_totalScore} points.\n");                          // Display total points
    
            lines = lines.Skip(1).ToArray();                                                 // Remove the first line and convert to an array  
    
            foreach (string line in lines)                                                   // Loop through each line in the array
            {
                string lineWithoutSpaces = line.Trim();                                      // Remove spaces from the beginning and end
    
                string[] parts = lineWithoutSpaces.Split(':', 2);                            // Split line into two parts at the first colon
    
                string goalType = parts[0].Trim();                                           // Extract goal type (SimpleGoal, EternalGoal, ChecklistGoal)
                string goalText = parts[1].Trim();                                           // Goal data after the colon
    
                Goal goal = null;
    
                if (goalType == "SimpleGoal")                                                // Check if the goal is a SimpleGoal
                {
                    SimpleGoal simpleGoal = new SimpleGoal(goalName: "", description: "", goalPoints: 0); 
                    goal = simpleGoal.PartsGoal(goalText);                                   // Break goal text into pieces to make a SimpleGoal                                        
                    _goals.Add(goal);                                                        // Add goal to the list
                }
                else if (goalType == "EternalGoal")                                          // Check if the goal is an EternalGoal
                {
                    EternalGoal eternalGoal = new EternalGoal(goalName: "", description: "", goalPoints: 0);  
                    goal = eternalGoal.PartsGoal(goalText);                                  // Break goal text into pieces to make a Eternalgoal                             
                    _goals.Add(goal);                                                        // Add goal to the list
                }
                else if (goalType == "ChecklistGoal")                                        // Check if the goal is a ChecklistGoal
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName: "", description: "", goalPoints: 0, targetCount: 0, bonusPoints: 0, currentCount: 0);  
                    goal = checklistGoal.PartsGoal(goalText);                                // Break goal text into pieces to make a ChecklistGoal                                                                          
                    _goals.Add(goal);                                                        // Add goal to the list
                }
    
                Console.WriteLine(goal.FormatGoal());                                        // Display goal details
            }
    
            
            Console.WriteLine("\nLoaded successfully!");                                     // Output the success message
        }
        else
        {
            Console.WriteLine("File not found.");                                            // Notify if file is not found
        }
    }

}


    
    
