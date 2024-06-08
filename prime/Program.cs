namespace prime
{
    using System;

    class PrimeChecker
    {
        public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to check if it's prime: ");
            int number = Convert.ToInt32(Console.ReadLine());

            PrimeChecker primeChecker = new PrimeChecker();
            bool isPrime = primeChecker.IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else if (isPrime)
            {
                Console.WriteLine(number + " is composite number.");

            }
            else 
            {
                Console.WriteLine(number + " is 0.");
            }
        }
    }

}
