 
using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();  //ArrayList does not have type safety, we can use
                                         //any kind of values as parameter
            
            list.Add(1);                 //here thge Add method takes object value as
                                         //its parameter, so Boxing happens as 1 is value type
                                         //Subsequently when we will get the value or cast
                                         //Unboxing will happen
            
            list.Add("Mosh");            // Boxing does not happen for string type because string 
                                         // itself is refernce type 
            
            list.Add(DateTime.Today);    //Again boxing happens for DateTime object as it is also
                                         // value type 


        //    var number = (int)list[1];      //This line will give an invalid exception
                                              // as we cannot cast a string to an integer

            
            var anotherList = new List<int>(); //Generic list we constraint the lists property type
            anotherList.Add(1);             // Here the add method will get integer type value 
            
            var names = new List<string>();
        }
    }
}


// Both Boxing and Unboxing has Performance Penalty, so better use the
// generic version if available 