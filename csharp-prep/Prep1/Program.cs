using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Prompt the user to input their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt the user to input their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // display the result
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        

    }
}