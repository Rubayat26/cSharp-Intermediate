using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);    //here this refers to Customer Class in amazon
                                                        //Inside the RateCalculator there the Calculator class is initialzed
                                                        //with Customer customer signature, thats why we need to give a customer 
                                                        //inside calculator.Calculate(this)
           
            
            return rating;
        }
    }
}