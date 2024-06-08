using System;


class Arithmetic
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}


class AdvancedCalculator : Arithmetic
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}


class ScientificCalculator : AdvancedCalculator
{
    public double Power(double x, double y)
    {
        return Math.Pow(x, y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ScientificCalculator scientificCalculator = new ScientificCalculator();

       
        Console.WriteLine("Scientific Calculator:");
        Console.WriteLine("Addition: " + scientificCalculator.Add(5, 3));         
        Console.WriteLine("Subtraction: " + scientificCalculator.Subtract(5, 3)); 
        Console.WriteLine("Multiplication: " + scientificCalculator.Multiply(5, 3)); 
        Console.WriteLine("Power: " + scientificCalculator.Power(5, 3));            
    }
}
