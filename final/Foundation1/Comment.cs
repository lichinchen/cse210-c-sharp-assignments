using System;             // Import system namespace

// The Comment class stores the commenter's name and text
public class Comment
{
    private string _name;  // Who wrote this comment
    private string _text;  // Texts in the comment

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment(int index)                 // Display comment with number
    {
        Console.Write($"{index}.");

        Console.ForegroundColor = ConsoleColor.Cyan;      // Set the color to Cyan
        Console.Write($" {_name}");
        Console.ForegroundColor = ConsoleColor.White;     // Set the color back to white

        Console.WriteLine($" -->> {_text}");
    }
}