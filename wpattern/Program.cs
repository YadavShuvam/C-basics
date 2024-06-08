namespace wpattern
{
    using System;

    public class Program
    {
        static void PrintStarsAndSpaces(int starsCount, int spacesCount)
        {
            for (int i = 0; i < starsCount; ++i)
                Console.Write("*");

            for (int i = 0; i < spacesCount; ++i)
                Console.Write(" ");
        }

        public static void Main(string[] args)
        {
            int n = 8;

            for (int i = 0; i < n; ++i)
            {
                PrintStarsAndSpaces(i + 1, n - i - 1);
                PrintStarsAndSpaces(n - i + 1, 2 * i);
                PrintStarsAndSpaces(n - i, n - i - 1);
                PrintStarsAndSpaces(i + 1, 0);

                Console.WriteLine();
            }
        }
    }

}
