using System;

namespace Pattern5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            //top part
            for (int i = 1; i <= n; i++)
            {
                //loop for space
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                //loop for stars
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //lower part
            for (int i = n - 1; i >= 1; i--)
            {
               
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

               
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
