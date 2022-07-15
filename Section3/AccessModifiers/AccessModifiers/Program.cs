using System;
using Amazon;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Amazon.RateCalculator calculator = new RateCalculator();
            
            
            Console.WriteLine(customer.Promote());         //without using system this console.writeline would not work.
        }
    }
}
