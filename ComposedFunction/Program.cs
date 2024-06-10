namespace ComposedFunction
{
    using System;

    class Program
    {
        static void Main()
        {
           
            Func<int, int> add5 = x => x + 10;
            Func<int, int> multiplyBy3 = x => x * 2;

            
            Func<int, int> composedFunction = x => multiplyBy3(add5(x));

            
            int result = composedFunction(2); 
            Console.WriteLine(result); 
        }
    }

}
