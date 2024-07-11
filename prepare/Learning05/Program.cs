using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;


List<Shape> shapes = new List<Shape>();

shapes.Add(new Square("Green", 6));
shapes.Add(new Rectangle("White",11, 7));
shapes.Add(new Circle("Blue", 8));


foreach (Shape shape in shapes)
{
    double calculateArea = shape.GetArea();
    Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {calculateArea}");
}

