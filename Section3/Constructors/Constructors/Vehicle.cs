using System;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;  //private accessModifier is not available in derived classes,
                                                      //So the base class constructor is called inside the constructor of the derived classes
                                                      //If we define it as protected we would be available to access it, but thats against 
                                                      //the idea of encapsulation 
//        public Vehicle()
//        {
//            Console.WriteLine("Vehicle is being initialized.");
//        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
