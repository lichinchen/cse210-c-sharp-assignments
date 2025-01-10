using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();                             // Display welcome message               
        string userName = PromptUserName();           // Get user's name
        int favoriteNum = PromptUserNumber();         // Get favorite number
        int squareNumber = SquareNumber(favoriteNum); // Calculate square
        DisplayResult(userName, squareNumber);
        
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!"); // Welcome message
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");   // Ask name
        string userName = Console.ReadLine();        // Get user name
        return userName;                             // Return the user's name
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: "); // Ask number
        string userInput = Console.ReadLine();                // Get user input as string
        int favoriteNum = int.Parse(userInput);               // Parse to int
        return favoriteNum;                                   // Return the favorite number
    }

    static int SquareNumber(int favoriteNum)
    {
        int squareNumber = favoriteNum * favoriteNum;         // Calculate square
        return squareNumber;                                  // Return squared number

    }

    static void DisplayResult(string userName, int squareNumber) //void means the function returns no value.
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}."); // Show squared result  
    }


    

}