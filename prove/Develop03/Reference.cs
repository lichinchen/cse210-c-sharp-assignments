public class Reference
{
    private string _book;     // Book name
    private int _chapter;     // Chapter number
    private int _startVerse;  // Start verse
    private int _endVerse;    // Default to startVerse

    // Constructor for a single verse 
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;             // Set book
        _chapter = chapter;       // Set chapter
        _startVerse = startVerse; // Set start verse
        _endVerse = startVerse;   // Set EndVerse to StartVerse
    }

    // Constructor for multiple verses 
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;              // Set book
        _chapter = chapter;        // Set chapter
        _startVerse = startVerse;  // Set start verse
        _endVerse = endVerse;      // Set end verse
    }

    public string GetBook()        // Getter for book
    { 
        return _book; 
    }
    public int GetChapter()        // Getter for chapter
    { 
        return _chapter; 
    }
    public int GetStartVerse()     // Getter for start verse
    { 
        return _startVerse; 
    }
    public int GetEndVerse()       // Getter for end verse
    { 
        return _endVerse; 
    }

    public string FormatReference() // Format reference 
    {
        if (_startVerse == _endVerse)  // Single verse
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else                           // Multiple verses
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
    
}
