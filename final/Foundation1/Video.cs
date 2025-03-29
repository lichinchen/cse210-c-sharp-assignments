using System;                      // Import system namespace
using System.Collections.Generic;  // For using Lists

// The Video class stores information about a video, like title, author, length, and comments
public class Video
{
    private string _title;                 // Store the video title
    private string _author;                // Store the video author
    private int _length;                   // Store the video length in seconds
    private List<Comment> _comments;       // List all comments
     
    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    
    // Method to count the number of comments
    public int GetCountComments()
    {
        return _comments.Count;  
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);  
    }


    public void DisplayVideoInfo(int index)
    {
        Console.ForegroundColor = ConsoleColor.Green;                    // Set the color to green
        Console.WriteLine($"~~~ Video {index} ~~~\n");
        Console.ForegroundColor = ConsoleColor.White;                    // Set the color back to white

        Console.ForegroundColor = ConsoleColor.Cyan;                     // Set the color to Cyan
        Console.Write($"- Title: ");                                     // Print the title, author, length of the video
        Console.ForegroundColor = ConsoleColor.White;                    // Set the color back to white

        Console.WriteLine($"{_title}");

        Console.ForegroundColor = ConsoleColor.Cyan;                     
        Console.Write($"- Author: ");                                     
        Console.ForegroundColor = ConsoleColor.White;                    

        Console.WriteLine($"{_author}");

        Console.ForegroundColor = ConsoleColor.Cyan;                     
        Console.Write($"- Length: ");                                     
        Console.ForegroundColor = ConsoleColor.White;                   

        Console.WriteLine($"{_length} seconds");

        Console.ForegroundColor = ConsoleColor.Cyan;                     
        Console.Write($"- Comments Count: ");                                     
        Console.ForegroundColor = ConsoleColor.White;                    

        Console.WriteLine($"{GetCountComments()}\n");


        Console.ForegroundColor = ConsoleColor.Yellow;                   
        Console.WriteLine("=== Comments ===\n");  
        Console.ForegroundColor = ConsoleColor.White;                    

        
        for (int i = 0; i < _comments.Count; i++)                        // Loop through all comments 
        {
            _comments[i].DisplayComment(i + 1);                          // Display the comment with its number
        }

        Console.ForegroundColor = ConsoleColor.DarkMagenta;                     // Set the color to blue
        Console.WriteLine("--------------------------------------------------------------------------------------"); 
        Console.ForegroundColor = ConsoleColor.White;                    // Set the color back to white
    }
}
