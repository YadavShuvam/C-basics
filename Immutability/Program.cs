namespace Immutability
{
    using System;

    public class ImmutablePerson
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public ImmutablePerson(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main()
        {
            ImmutablePerson person = new ImmutablePerson("Ram", "Shyam", 20);
            Console.WriteLine(person);

            ImmutablePerson anotherPerson = new ImmutablePerson("Shyam", "Ram", 30);
            Console.WriteLine(anotherPerson);
        }
    }
}
