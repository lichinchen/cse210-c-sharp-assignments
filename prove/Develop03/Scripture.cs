using System;                      // Import System
using System.Collections.Generic;  // Import collections

public class Scripture
{
    private static Random _random = new Random();  // Random generator
    private Reference _reference;                  // Scripture reference
    private List<Word> _words;                     // List of words
    

    public Scripture(Reference reference, string text)  // Constructor
    {
        _reference = reference;                         // Set reference
        _words = new List<Word>();                      // Initialize list

        foreach (string word in text.Split(' '))        // Split text into words
        {
            Word newWord = new Word(word);              // Create word object
            _words.Add(newWord);                        // Add to list
        }

    }

    public void HideRandomWords(int count = 2)          // Hide random words
    {
        List<Word> visibleWords = new List<Word>();     // Visible words list

        foreach (Word word in _words)                   // Check for visible words
        {
            if (!word.IsHidden())                       // If word is not hidden
            {
                visibleWords.Add(word);                 // Add to list
            }
        }

        if (visibleWords.Count == 0)                    // No visible words
        {
            return;                                     // Exit
        }

        for (int i = 0; i < count && visibleWords.Count > 0; i++)  // Hide 'count' words
        {
            int index = _random.Next(0, visibleWords.Count);        // Get random index
            Word randomWord = visibleWords[index];                 // Get word
            randomWord.Hide();                                     // Hide the word
            visibleWords.RemoveAt(index);                          // Remove from list
        }
    }

    public bool AllWordsHidden()
    {
        // Check if all words are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())  // If any word is visible
            {
                return false;  // Return false if there's any visible word
            }
        }
        return true;  // Return true if all words are hidden
    }

    public string DisplayText()
    {
        string result = _reference.FormatReference() + "\n";
    
        foreach (var word in _words)
        {
            result += word.DisplayWord() + " ";  // Add each word with a space
        }
    
        return result.Trim();  // Remove any extra space at the end
    }

}
