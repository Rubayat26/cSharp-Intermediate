
using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person(new DateTime(1982, 1, 1));
            person1.Name = "Rahim";
            Console.WriteLine(person1.Name);
            Console.WriteLine( person1.Age);
        }
    }
}
 