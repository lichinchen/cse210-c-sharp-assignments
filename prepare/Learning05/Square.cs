public class Square : Shape
{
    private double _side;  // stores the side length
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;  // Calculates area
    }


}