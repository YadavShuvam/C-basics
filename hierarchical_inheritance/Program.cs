using System;


class Arithmetic
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    
}


class AdvancedCalculator : Arithmetic
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}


class SimpleCalculator : Arithmetic
{
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        AdvancedCalculator advancedCalculator = new AdvancedCalculator();
        SimpleCalculator simpleCalculator = new SimpleCalculator();

        
        Console.WriteLine("Addition: " + advancedCalculator.Add(5, 3));         
       
        Console.WriteLine("Multiplication: " + advancedCalculator.Multiply(6, 7)); 

       
        Console.WriteLine("Addition: " + simpleCalculator.Add(5, 3));        
        Console.WriteLine("Subtraction: " + simpleCalculator.Subtract(10, 4)); 
    }
}
