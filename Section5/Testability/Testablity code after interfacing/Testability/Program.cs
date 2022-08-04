using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 20f};
            orderProcessor.Process(order);   // here we are trying to build an unit
                                             // test for the OrderProcessor Class 
                                             // And the OrderProcessor has the method 
                                             // Process in it 
        }
    }
}

// here inside the new OrderProcessor instance we are still passing the argument
// as the concrete class ShippingCalculator; not the interfaced one IShippingCalculator
// Beacuase it is inside the Main method, not inside the OrderProcessor class 
// The main method works as like a match maker 
// The main method knows different concrete class and ties them together;
// But none of the concrete type like OrderProcessor knows about the existence of other
// concrtete types 
