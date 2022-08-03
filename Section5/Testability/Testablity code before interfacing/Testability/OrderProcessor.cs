using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalculator; // declaring _shippingCalculator
                                                                 // as a private property of
                                                                 // OrderProcessor, 
                                                                 //Type Shipping Calculator Class
        

        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)  //order.isShipped is True this if block will run 
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment  
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}


// here we are creating a new shipment and assigning it to the Shipment property of order

// the Shimpment class has two properies as declared in Shipment.cs, one is cost and 
// another one is ShippingDate 
// While assigning Cost to the Shipment class we use the CalculateShipping method of the 
//_shippingCalculator which takes order as an argument


