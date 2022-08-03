namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator  // this simply says, Shipping
                                                           // Calculator implements
                                                           // IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}


// Interfacing looks to simiar to inheritance but it is not 