// Base class
public abstract class Shape              // Abstract base class for all shapes
{
    private string _color;             // stores the color of the shape
    public Shape(string color)           // Constructor 
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;                   // returns the color
    }
    public abstract double GetArea();    // Abstract method to be overridden
}
