using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }      // write prop + Tab +Tab to generate this; code snippet

        public int Promote()
        {
            var calculator = new RateCalculator();   // This is not a good practice to initiate a object 
                                                     // inside anothe method, this creates coupling 
            var rating = calculator.Calculate(this);   //we pass this as the object as the Customer object to that method 
                                                        //here this refers to current instance of the Customer Class in Amazon namespace
                                                        //Inside the RateCalculator there the Calculator class is initialzed
                                                        //with Customer customer signature, thats why we need to give a customer 
                                                        //inside calculator.Calculate(this)
           
            
            return rating;
        }
    }
}