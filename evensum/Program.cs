namespace evensum
{
    using System;

    class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 2; i <= 50; i += 2)
            {
                sum += i;
            }

            Console.WriteLine("Sum of even numbers from 1 to 50 is : " + sum);
        }
    }

}
