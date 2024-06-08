using System;

namespace PrintPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 5;

            //print top stars
            for (int j = 1; j <= cols; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();




            
            for (int i = 1; i <= rows - 2; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= cols - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }




            //print lower stars
            for (int j = 1; j <= cols; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
