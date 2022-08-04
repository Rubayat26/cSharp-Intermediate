using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)  //here orderProcessor is 
                                                                     //taking a parameter of type 
                                                                     //IShippingCalculator
        {
            _shippingCalculator = shippingCalculator;
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


// Now if we go change some properties in ShippingCalculator
// 


// Here we did not create interaces for order beacuase here we are trying to test how 
// the order is processed here and we wanted to keep it independent of the 
//CalculateShipping property of the shippingCalculator 