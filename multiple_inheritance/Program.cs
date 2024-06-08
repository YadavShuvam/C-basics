using System;


interface IArithmetic
{
    int Add(int a, int b);
    int Subtract(int a, int b);
}


interface IAdvancedMath
{
    int Multiply(int a, int b);
}


class Arithmetic : IArithmetic
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


class AdvancedMath : IAdvancedMath
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}


class Calculator : IArithmetic, IAdvancedMath
{
    private IArithmetic arithmetic = new Arithmetic();
    private IAdvancedMath advancedMath = new AdvancedMath();

    public int Add(int a, int b)
    {
        return arithmetic.Add(a, b);
    }

    public int Subtract(int a, int b)
    {
        return arithmetic.Subtract(a, b);
    }

    public int Multiply(int a, int b)
    {
        return advancedMath.Multiply(a, b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        
        Console.WriteLine("Addition: " + calculator.Add(5, 3));         
        Console.WriteLine("Subtraction: " + calculator.Subtract(5,3)); 

       
        Console.WriteLine("Multiplication: " + calculator.Multiply(5, 3)); 
    }
}
