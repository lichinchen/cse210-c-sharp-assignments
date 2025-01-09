using System;                // Import system namespace
using System.Globalization;  // Import globalization namespace

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");  // Prompt user for input
        List<int> numbers = new List<int>();  // Initialize a list
        
        int sum = 0;  // Initialize sum variable
        

        while (true)  // Start loop for user input
        {
            Console.Write("Enter number: ");  // Prompt for number
            string enterNumber = (Console.ReadLine());  // Read user input
            int number = int.Parse(enterNumber);   // Convert input to integer
            
            
            if (number == 0)  // Exit loop if input is 0
            {
                break;
            }
            numbers.Add(number);  // Add number to the list
            sum += number;        // Add number to sum
            
            
        }  
        double average = sum / ((double)numbers.Count);                         // Calculate average
        int maxNumber = numbers.Max();                                          // Find the largest number  

        
        Console.WriteLine($"There are total numbers in list: {numbers.Count}"); // Output count of numbers
        Console.WriteLine($"The list contains: " + string.Join(", ", numbers)); // Output the list
        Console.WriteLine($"The sum is : {sum}");                               // Output the sum
        Console.WriteLine($"The average is: {average:F2}");                     // Output the average
        Console.WriteLine($"The largest number is: {maxNumber}");               // Output the largest number  
    }
}