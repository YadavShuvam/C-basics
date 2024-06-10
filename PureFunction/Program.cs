namespace PureFunction
{
    using System;

    class Program
    {
        static void Main()
        {
            int result = Subtract(10, 5);
            Console.WriteLine(result); 

            int result2 = Subtract(10, 5);
            Console.WriteLine(result2);

            int randomNumber = GenerateRandomNumber();
            Console.WriteLine($"Random Number: {randomNumber}");



        }

       
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        
         static  int GenerateRandomNumber()
        {
            return new Random().Next();
        }

    }

}
