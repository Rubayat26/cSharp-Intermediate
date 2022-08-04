using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testability.UnitTests
{
    [TestClass] // each test class has attributes as test class and bunch of methods 
    public class OrderProcessorTests    //OrderProcessor is the class we are testing 
    {
        

        [TestMethod]  // these are merely some attributes, they dont have any logic
                      // attributes contains meta data about your classes and their members 
        [ExpectedException(typeof(InvalidOperationException))] //Anoter assembly can read this
                                                               //meta data and do something about it 

        // METHODNAME_CONDITION_EXPECTATION
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator()); 
            var order = new Order();

            orderProcessor.Process(order);

            // so these assert conditions are to check the values after
            // orderProcessor.Process(order) is run
            // so now the IsShipped should be true
            // the Shipment.Cost should be 1 as we are retuning 1 from the fakeShipping calculator
            // Shpping date should be tomorrwo based on the logic 

            
            Assert.IsTrue(order.IsShipped);  // to assert that Order.shipment is
                                             // initialized properly
                                             // but nothing in order.shippement
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator   // to generate the calculate shipping method "alt+enter" and then "enter" again
    {
        public float CalculateShipping(Order order)    // methods declared in an interface
                                                       // needs to be public
                                                       // CalculateShipping was the only method
                                                       // described inside ShippingCalculator 
        {
            return 1;      // no logic here, this return does not mean anything, we just want that 
                           //fake class working 
        }
    }
}


// here inside new OrderProcessor we are passing a FakeShippingCaclulator as we need to pass a 
//IShippingCaclulator;  Here our goal is to isolate the process so we need to pass an object which 
// is always working 



// Here our motive to make the Orderprocessor Independent of the shippingCalculator 




// This [TestClass] and [TestMethod] are attributes that we can use later on to run tests 