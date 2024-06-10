namespace HigherOrderFunctions
{
    using System;

    class Program
    {
        static void Main()
        {
            
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(add(2, 2)); 

           
            ApplyOperation(add, 5, 5); 
        }

       
        static void ApplyOperation(Func<int, int, int> operation, int a, int b)
        {
            Console.WriteLine(operation(a, b));
        }
    }

}
