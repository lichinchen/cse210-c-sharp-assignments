// I created two type animations. One for breathing cycle and one for the end of each activity.
// I created a menu for the duration. It will help the user to input the time easier.
// I added some code to reminder the user the cycle of the number. It will help the user know how many times he need to do the breathing cycle.
// 


using System;  // Import System

public class Program
{
    public static void Main(string[] args)
    {
        // Display welcome message and options to the user
        Console.WriteLine("~~ Welcome to Mindfulness Activity ~~");
        Console.WriteLine("\nChoose an activity:");
        
        // Keep asking until a valid choice is entered
        while (true)
        {
            // Let the user choose an activity
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nEnter the number of the activity you want to do: ");

            string input = Console.ReadLine();  // Read the user's input
            int choice;                         // Declare a variable to store the user's choice

            // Try to convert the input string to an integer
            try
            {
                choice = int.Parse(input);  // Try to convert the input to an integer
                Console.Clear();
                Console.WriteLine("\nThe number you entered is: " + choice);  // If successful, display the result
            }
            catch
            {
                // If the conversion fails, this block will be executed
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;  // Prompt the user again
            }

            // If the user selects 4, exit the program
            if (choice == 4)
            {
                Console.WriteLine("\nGoodbye!\n");
                return;
            }
    
            if (choice == 1)       // Breathing
            {
                Console.WriteLine("\nYou selected Breathing Activity.");
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity helps you relax with Breathing. \nClear your mind and focus on your breathing.", 5);
                breathing.ExecuteBreathingActivity();
            }
    
            else if (choice == 2)  // Reflection
            {
                Console.WriteLine("\nYou selected Reflecting Activity.");
                ReflectingActivity reflection = new ReflectingActivity("Reflection", "This activity helps you reflect on meaningful life experiences. \nThis will help you recognize the power you have and how can use it in other aspects of your life.", 5, 10);
                reflection.ExecuteReflectionActivity();
            }
    
            else if (choice == 3)  // Listing
            {
                Console.WriteLine("\nYou selected Listing Activity.");
                ListingActivity listing= new ListingActivity("Listing", "This activity helps you list good things in your life.", 5, 10);
                listing.ExecuteListingActivity();
            }
    
            Console.WriteLine("\nPress Enter to return to the main menu...");
            Console.ReadLine(); 
            Console.Clear();

        }    
    }
}
