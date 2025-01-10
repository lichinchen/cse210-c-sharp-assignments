using System;                // Import system namespace
using System.Globalization;  // Import globalization namespace

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");  // Prompt user for input
        List<int> numbers = new List<int>();  // Empty numbers list
        List<int> positiveNums = new List<int>();  // Empty positiveNums list
        
        
        
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

        foreach (int number in numbers)    // Loop through the numbers list
        {
            if(number > 0)                 // Check if the number is positive
            {
                positiveNums.Add(number);  // Add positive numbers to positiveNums list
            }
        }

        int smallestNum = positiveNums.Min(); // Find the smallest positive number
        
        Console.WriteLine($"There are total numbers in list: {numbers.Count}"); // Output count of numbers
        Console.WriteLine($"The list contains: " + string.Join(", ", numbers)); // Output the list
        Console.WriteLine($"The sum is : {sum}");                               // Output the sum
        Console.WriteLine($"The average is: {average:F3}");                     // Output the average
        Console.WriteLine($"The largest number is: {maxNumber}");               // Output the largest number  
        Console.WriteLine($"The smallest positive number is: {smallestNum}");   // output the smallest positive number

        List<int> sortNums = new List<int>(numbers);  // Empty sortNums list
        sortNums.Sort();                              // Sort the list
        Console.WriteLine("The sorted list is: ");    // Display sorted list
        foreach (int number in sortNums)
        {
            Console.WriteLine(number);                // Loop through sorted list and print each number
        }
        
    }
}