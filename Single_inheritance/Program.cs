using System;

class Math
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

class Math2 : Math
{
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Calculate
{
    static void Main(string[] args)
    {
        Math2 m = new Math2();
        int resultAdd = m.Add(1, 2);
        int resultSubtract = m.Subtract(1, 2);
        int resultMultiply = m.Multiply(1, 2);

        Console.WriteLine("Addition result: " + resultAdd);       
        Console.WriteLine("Subtraction result: " + resultSubtract); 
        Console.WriteLine("Multiplication result: " + resultMultiply);
    }
}
