using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();             // List of shapes

        Square square = new Square("Red", 4);               // Create a Square object  
        shapes.Add(square);                                 // Add it to the list 

        Rectangle rectangle = new Rectangle("Blue", 5, 3);  // Create a Rectangle object  
        shapes.Add(rectangle);                              // Add it to the list  
        
        Circle circle = new Circle("Green", 2.5);           // Create a Circle object  
        shapes.Add(circle);                                 // Add it to the list 

        foreach (Shape shape in shapes)                     // Loop through shapes
        {
            string color = shape.GetColor();                // Get the color of the shape  
            double area = shape.GetArea();                  // Get the area of the shape  
            
            Console.WriteLine($"Color: {color}, Area: {area:F2}");  // Print the details  
        }
    }
}