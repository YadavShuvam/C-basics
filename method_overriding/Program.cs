namespace method_overriding
{
    using System;

   
    class Shape
    {
       
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

   
    class Circle : Shape
    {
       
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

   
    class Square : Shape
    {
        
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle(); 
            Shape shape2 = new Square(); 

            
            shape1.Draw();
            shape2.Draw();
        }
    }

}
