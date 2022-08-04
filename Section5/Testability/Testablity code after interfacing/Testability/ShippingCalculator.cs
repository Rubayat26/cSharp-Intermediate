
using System;


namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);  //no accessmodifiers and no body 
    }

    public class ShippingCalculator : IShippingCalculator  // this simply says, Shipping
                                                           // Calculator implements
                                                           // IShippingCalculator
    {
        public float CalculateShipping(Order order)    //methods described interface needs to
                                                       //be public
        {
            if (order.TotalPrice < 30f) 
            {
                Console.WriteLine(order.TotalPrice * 0.1f);
                return order.TotalPrice * 0.1f; 
            }
                 

            return 0;
        }
    }
}


// Interfacing looks to simiar to inheritance but it is not 