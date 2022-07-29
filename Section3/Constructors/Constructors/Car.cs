using System;

namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) //base constructors are not inherited normally to the inherited class
            : base(registrationNumber)  //base class constructor is executed first
            
                                        // after we commented out the base contructors parameterless,
                                        //constructor class, nwe cannot set parameterless constructor for car 

                                        // we need to say base to pass the control to the base constructor of vehicle
        {
            // intializes fields specific to car class
            
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}




//here what will happen every time, we try create a new car object the runtime will first run the base constructor of 
// of the vehicle class and then come back to the constructor of the car class



// here we have to pass a string to the base as the base vehicle constructors now need one string
// regsitration number and we pass it thoright the paramete of the car constructor 