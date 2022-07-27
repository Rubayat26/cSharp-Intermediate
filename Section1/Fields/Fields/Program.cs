
using System;

namespace Fields
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1); // here we have to supply an id, because of the contructor there os no parameterless constructor
            customer.Orders.Add(new Order());  //Order added to customers orders
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
