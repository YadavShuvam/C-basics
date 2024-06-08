namespace factorial
{
    using System;

    class FactorialCalculator
    {
        public long Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                long result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            FactorialCalculator f= new FactorialCalculator();
            long factorial = f.Factorial(number);

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
    }

}
