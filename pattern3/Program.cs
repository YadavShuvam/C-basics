namespace pattern3
{
    using System;

    namespace PrintPattern
    {
        class Program
        {
            static void Main(string[] args)
            {
                int rows = 5;

                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }
    }

}
