using System;


abstract class Shape
{
   
    public abstract double CalculateArea();
}


class Rectangle : Shape
{
    
    public double Width { get; set; }
    public double Height { get; set; }

    
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

   
    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Rectangle rectangle = new Rectangle(5, 4);

       
        double area = rectangle.CalculateArea();

       
        Console.WriteLine("Area of the rectangle: " + area); 
    }
}
