namespace multable
{
    using System;

    class Multiply
    {
        public void Multable(int number)
        {
            Console.WriteLine("Multiplication table for " + number + ":");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + (number * i));
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Multiply m = new Multiply();
            m.Multable(number);
        }
    }


}
