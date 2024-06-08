namespace method_overloading
{
    using System;

    class Calculator
    {
        
        public int Add(int a, int b)
        {
            return a + b;
        }

        
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

       
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            
            int sum1 = calculator.Add(5, 3);
            int sum2 = calculator.Add(5, 3, 2);
            double sum3 = calculator.Add(5.5, 3.7);

            Console.WriteLine("Sum 1: " + sum1); 
            Console.WriteLine("Sum 2: " + sum2); 
            Console.WriteLine("Sum 3: " + sum3); 
        }
    }

}
