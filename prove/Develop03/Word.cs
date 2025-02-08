public class Word             // Represents a word
{
    private string _text;     // Word text
    private bool _isHidden;   // Hidden state

    public Word(string text)  // Constructor
    {
        _text = text;         // Set text
        _isHidden = false;    // Not hidden
    }

    public void Hide()        // Hide the word
    {
        _isHidden = true;     // Set hidden
    }

    public bool IsHidden()    // Check if hidden
    {
        return _isHidden;     
    }

    public string DisplayText()  // Return text or placeholder if hidden
    {
        if (_isHidden)           // Check if the word is hidden
        {
            return "_____";
        }
        else                     // If not hidden
        {
            return _text;
        }
    }

}