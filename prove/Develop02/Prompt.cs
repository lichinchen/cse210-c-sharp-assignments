using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> _prompts;  // List of prompts
    private Random randomPrompt;  // Random chooser
    public Prompt()  // Constructor
    {
        _prompts = new List<string>()   // Set up prompts 
        {
        "What is one thing you are grateful for today?",
        "What is something new I learned today?",
        "What moment today made me feel proud of myself?",
        "What was something hard you fixed today?",
        "How did I take care of myself today?",
        "What made me smile today?",
        "How did I show kindness today?",
        "What did I do today that made me feel strong?",
        "How did I bring joy to someone else today?",
        "How did I practice patience today?"
        };

        randomPrompt = new Random();   // Create random chooser  
    }
    

    public string PromptIndex()  // Get random prompt
    {
        int promptIndex = randomPrompt.Next(_prompts.Count);  // Generate random index
        return _prompts[promptIndex];  // Return prompt 
    } 
}