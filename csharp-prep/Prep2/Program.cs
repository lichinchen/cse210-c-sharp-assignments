/*
using System; tells the C# program to use the built-in toolset called System, 
so we can directly use its features, like the Console class for input and output, 
without needing to write System.Console every time. 
It simplifies the code and makes programming more convenient.
*/
using System; // Import System for input/output

class Program
{
    static void Main(string[] args) // Program starts here
    {
        try
        {
            Console.Write("Enter your grade percentage: "); // Prompt for grade
            string userInput = Console.ReadLine();          // Get input
            int grade = int.Parse(userInput);               // Convert to integer
    
            string letter = ""; // Store letter grade
            string sign = "";
            int lastDigit = grade % 10; 
            
            if (grade >= 90)
            {
                letter = "A";
                if (lastDigit < 3)
                {
                    sign = "-";
                }
                else 
                {
                    sign = "";
                }
            }
            else if (grade >= 80)
            {
                letter = "B";
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else if (grade >= 70)
            {
                letter = "C";
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else if (grade >= 60)
            {
                letter = "D";
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else 
            {
                letter = "F";
                sign = "";
            }
    
            
            
            
            string gradeSign = letter + sign;
            Console.WriteLine($"Your grade is {gradeSign}");
    
            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed."); // Passed
            }
            else
            {
                Console.WriteLine("Keep trying! You'll do better next test!"); // Failed
            }
        }
        catch (FormatException) // Catch input format error. (non-integer)
        {
            Console.WriteLine("Invalid input. Enter a whole number.");
        }
        
        
    }
}