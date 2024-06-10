namespace FirstClassFunctions
{
    using System;

    class Program
    {
        static void Main()
        {
            
            Func<string, string> greet = name => $"Hello, {name}";
            Console.WriteLine(greet("Ram"));

            
            string CallFunction(Func<string, string> func, string name)
            {
                return func(name);
            }

            Console.WriteLine(CallFunction(greet, "Shyam"));

            
            Func<string, string> OuterFunction()
            {
                return name => $"Hi, {name}";
            }

            var hello = OuterFunction();
            Console.WriteLine(hello("Hari"));
        }
    }

}
