

using System;

namespace Casting
{
  
    
    class Program
    {
        public class Utensil                 // Line 11 - 26, 43-62 for practicing and understanding
                                             // upcasting and downcasting 
                                             
        {
            public int width;
        }
        
        public class Box : Utensil
        {
             
        }

        public class Mug : Utensil
        {
            
        }
        
        
        
        
        static void Main(string[] args)
        {
            Shape shape = new Text();  //although in compile time the type of the shape object would be 
                                       // Shape; at runtime the type would be text 
            Text text = (Text) shape;  // Downcasting , becasue shape object would have limited properties
                                      // converting the shape object to text we get access al the properies
                                      // of text type 

            


            
            Box box = new Box();
            Utensil utensilBox = box;   // converting box to its base class Utensil

            //both box and UtensilBox is pointing to the same memory location but thier view is 
            //different
            
            Box anotherBox = (Box)utensilBox;
            // Mug mug = (Mug)utensil; // you can only downcast to its original derived class

            Mug mug = new Mug();
            Utensil utensilMug = mug;

            Mug anotherMug = (Mug)utensilMug;


            box.width = 200;
            utensilBox.width = 100;
            
            Console.WriteLine(box.width);   //box width will result in 100, because both box.width and 
                                            //utensilBox.width are pointing to the same memory location
        }
    }
}
