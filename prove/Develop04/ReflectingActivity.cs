using System;            // Import System
using System.Threading;  // Import System


public class ReflectingActivity : Activity
{
    private int _reflectionTime;   // Stores the duration 

    // Array of prompts for reflection  
    private string[] _prompts =  
    {  
        "--- Think of a time when you stood up for someone. ---",
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Have you ever experienced failure? ---",
        "--- Think of a time when you overcame fear. ---" 
    };  
    
    // Array of questions for deeper thinking  
    private string[] _questions =  
    {  
        ">>> Why was this experience meaningful to you?",  
        ">>> How did you feel when it was complete?",  
        ">>> What did you learn about yourself?",  
        ">>> How did this experience change your perspective on life?",  
        ">>> What would you do differently if you faced a similar situation again?" 
    };  

    // Constructor for ReflectingActivity class
    // Initializes the name, description, duration from the base class (Activity)
    public ReflectingActivity(string name, string description, int duration, int reflectionTime)
        : base(name, description, duration)  // Initializes base class properties
    {
        _reflectionTime = reflectionTime;    // Store the reflection time
    }

    // Get random prompt from list
    public string GetRandomPrompt()
    {
        Random rand = new Random();                    // Create random number generator
        int randomIndex = rand.Next(_prompts.Length);  // Get random index
        return _prompts[randomIndex];                  // Return random prompt
    }

    // Display prompt to user
    public void displayPrompt()
    {
        Console.Clear();
        Console.WriteLine("\nConsider the following prompt: \n");
        Console.WriteLine(GetRandomPrompt());          // Display a random prompt
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();                            // Waits for user input
    }

    // Get random question from list
    public string GetRandomQuestion()
    {
        Random rand = new Random();                      // Create Random object
        int randomIndex = rand.Next(_questions.Length);  // Get random index
        return _questions[randomIndex];                  // Return random question
    }

    // Display question to user
    public void displayQuestion()
    { 
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        for (int i = _reflectionTime; i > 0; i--)             // Countdown from 10 to 1
        {
            Console.SetCursorPosition(0, Console.CursorTop);  // Position the cursor at the start 
            Console.Write($"You may begin in: {i} ");         // Print the countdown number
            Thread.Sleep(1000);                               // Wait for 1 second
        }

        Console.WriteLine();     
        Console.Clear();
        Console.WriteLine(GetRandomQuestion());               // Display a random question
        for (int i = _reflectionTime; i >= 0; i--)            // Countdown from 10 to 1
        {
            Console.SetCursorPosition(0, Console.CursorTop);  // Position the cursor at the start 
            Console.Write($"Countdown: {i} ");                // Print the countdown number
            Thread.Sleep(1000);                               // Wait for 1 second    
        } 
    }

    // Run Reflection Activity
    public void ExecuteReflectionActivity()
    {
        ExecuteStartActivity();   // Inherited method
        displayPrompt();          // Show random prompt
        displayQuestion();        // Show random question
        ExecuteEndActivity();     // Inherited method
    }

}
