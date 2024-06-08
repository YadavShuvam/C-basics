namespace encapsulation
{
    using System;

    class Person
    {
       
        private string name;

      
        public Person(string name)
        {
            this.name = name;
        }

       
        public string GetName()
        {
            return name;
        }

        
        public void SetName(string newName)
        {
            name = newName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("ram");

            
            Console.WriteLine("Current name: " + person.GetName());

            
            person.SetName("ram2");
            Console.WriteLine("New name: " + person.GetName());
        }
    }

}
