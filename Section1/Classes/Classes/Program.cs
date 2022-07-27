

using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)      //to is referred as the string input 
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)     // here we are trying to create an object from a string
        {
            var person = new Person();            // creating a new person inside the parse method
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var person = Person.Parse("John");
            //person.Introduce("Mosh");

            var person1 = new Person();
            person1.Name = "Rubayat";
            person1.Introduce("Mosh");
        } 
    }
}
