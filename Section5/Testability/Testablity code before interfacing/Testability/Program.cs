using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();  // creating an instance of the
                                                        // order processor
            var order1 = new Order {DatePlaced = DateTime.Now, TotalPrice = 20f};
            orderProcessor.Process(order1);  // OrderProcessor has a Process method
                                             // which takes order object as argument
                                              

            orderProcessor.Process(order1);  //This line will throw an exception

        }
    }
}
// Here the goal of interfacing to write unit test for OrderProcessor 