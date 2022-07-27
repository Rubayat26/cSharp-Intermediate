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
            var whatever = new RateCalculator();  // here we used var instead of Amazon.Ratecalculator
            
            
            Console.WriteLine(customer.Promote());         //without using system this console.writeline would not work.
        }
    }
}
