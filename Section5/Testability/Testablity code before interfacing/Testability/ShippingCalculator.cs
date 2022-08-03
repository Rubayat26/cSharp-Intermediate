
using System;

namespace Testability
{
    
    public class ShippingCalculator 
    {
        public float CalculateShipping(Order order) //It takes Order type class as a
                                                    //parameter 
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