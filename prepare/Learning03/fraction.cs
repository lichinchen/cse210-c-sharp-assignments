using System;

public class Fraction
{
    private int _top;      // Numerator
    private int _bottom;   // Denominator

    // 1. Default constructor: Initializes fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2. Constructor with one parameter: Initializes fraction to top/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // 3. Constructor with two parameters: Initializes fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        if (bottom != 0) // Ensure denominator is not zero
        {
            _top = top;
            _bottom = bottom;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Getter for numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for numerator
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for denominator (ensures denominator is not zero)
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    // Returns the fraction in "numerator/denominator" format
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
