using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)        // This is the object constructor 
        {
            Birthdate = birthdate;
        }
        
        

        public int Age                          // for the Age we do not need any set method, as it is based on birthday  
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;  //when we subtract or add two dates we get a timespan
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}