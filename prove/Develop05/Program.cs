using System;  // Basic system

// exceeds the assignment requirements:
// 1. Check if the goal is already completed and prevent duplicate point awards.
// 2. I added the feature to count how many times the Eternal Goal is completed and track the points earned.
// 3. I made it so the user can see the points earned each time a goal is completed, along with the details of the points.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~ Eternal Progress ~~");                                      // Displays the title
        Console.WriteLine("============================");  
        GoalTracker goalTracker = new GoalTracker();                                      // Create GoalTracker object

        while (true)                                                                      // loop for the menu
        {
            Console.WriteLine("You have " + goalTracker.GetTotalScore() + " points.");  // Show total points
            Console.WriteLine("\nMenu Options: ");                                          // Display menu
            Console.WriteLine("1. Create New goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string input = Console.ReadLine();                                            // Read user's input
            int choice;                                                                   // Declare choice variable

            try                                                                           // Try to convert the input to an integer
            {
                choice = int.Parse(input);                                                // Convert input to integer
                Console.Clear();                                                          // Clears the console screen 
                Console.WriteLine("\nThe number you entered is: " + choice);              // Display choice
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");         // Error message
                continue;                                                                 // Retry input
            }

            if (choice == 1)                                                              // Create New goal
            {
                Console.WriteLine("\nYou selected to create a new goal.");                
                Console.WriteLine("\nThe types of Goals are: ");                          // Lists goal types
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goals");
                Console.WriteLine("3. Checklist goals");
                Console.Write("\nWhich type of goal would you like to create? ");
                string goalType = Console.ReadLine();                                     // Get goal type
                Console.Write("What is the name of your goal? "); 
                string goalName = Console.ReadLine();                                     // Get goal name
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();                                  // Get goal description
                Console.Write("What is the amount of points associated with this goal? ");
                string amountPoints = Console.ReadLine();                                 // Get goal points
                int goalPoints = int.Parse(amountPoints);

               
                if (goalType == "1")                                                      // Simple Goal
                {
                    SimpleGoal newGoal = new SimpleGoal(goalName, description, goalPoints);
                    goalTracker.AddGoal(newGoal);                                         // Add new goal
                    Console.WriteLine("\nGoal Created: " + newGoal.GetStatus());
                }
                else if (goalType == "2")                                                 // Eternal Goal
                {
                    EternalGoal newGoal = new EternalGoal(goalName, description, goalPoints);
                    goalTracker.AddGoal(newGoal);                                         // Add new goal
                    Console.WriteLine("\nGoal Created: " + newGoal.GetStatus());
                }
                else if (goalType == "3")                                                 // ChecklistGoal
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string goalTimes = Console.ReadLine();                               // Get target count
                    int targetcount = int.Parse(goalTimes);                              // convert string to int
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    string bonus = Console.ReadLine();                                   // Get bonus points
                    int bonusPoints = int.Parse(bonus);                                  // convert string to int
                    Console.Write("How many times has this goal been accomplished so far? ");
                    string current = Console.ReadLine();                                 // Get current count
                    int currentCount = int.Parse(current);                               // Convert string to int
                    ChecklistGoal newGoal = new ChecklistGoal(goalName, description, goalPoints, targetcount, bonusPoints, currentCount);
                    goalTracker.AddGoal(newGoal);                                        // Add new goal
                    Console.WriteLine("\nGoal Created: " + newGoal.GetStatus());
                }
                else
                {
                    Console.WriteLine("Invalid goal type. Please choose 1, 2, or 3.");
                }
            }
            else if (choice == 2)                                                        // List goals
            {
                Console.WriteLine("\nYou selected to List Goals.");
                Console.WriteLine("\nThe goals are: \n");
                goalTracker.DisplayGoals();                                              // Display all goals
            }
            else if (choice == 3)                                                        // Save goals
            {
                Console.WriteLine("\nYou selected to Save Goals.");
                goalTracker.SaveGoals();                                                 // Save goals to file
            }
            else if (choice == 4)                                                        // Load goals
            {
                Console.WriteLine("\nYou selected to Load Goals.");
                goalTracker.LoadGoals();                                                 // Load goals from file
            }
            else if (choice == 5)                                                        // Record event
            {
                Console.WriteLine("\nYou selected to record event.");
                goalTracker.AllRecordEvent();                                            // Record an event for goals
            }
            else if (choice == 6)                                                        // Quit
            {
                Console.Write("Are you sure you want to quit? (y/n) ");
                string quitChoice = Console.ReadLine();                                  // Ask for confirmation
                if (quitChoice.ToLower() == "y")
                {
                    Console.WriteLine("\nThank you! Goodbye!\n");                        // Exit message
                    return;  // Exit program
                }
                else if (quitChoice.ToLower() == "n")
                {
                    Console.WriteLine("\nReturning to the main menu....");
                    Console.WriteLine("\nPress Enter to return to the main menu...");
                    Console.ReadLine();                                                  // Return to main menu
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter 'y' or 'n'.");      // Invalid input
                }
            }

            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine();                                                         // Wait for user to press Enter
            Console.Clear();                                                            // Clear screen for next menu
        }    
    }
}
