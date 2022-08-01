using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle { 
                Width = 100, Height = 30, Position = new Position(40,20) }); 
                                                                 //Hieght, width and position
                                                                 //properties can be added like
                                                                 //this

            shapes.Add(new Rectangle());       // here the add method requires to give it
                                               // different shape items, and with new kewyord
                                               // we are creating new instances of the class 
            shapes.Add(new Triangle());


            shapes.Add(new Shape());
            
            
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);



           
           /*
            * var shapes = new List<Shape>();
            * shapes.Add(New Shape { Width = 100, Hieght =100, Type = ShapeType.Circle });
            * shapes.Add(New Shape { Width = 100, Hieght =30, Type = ShapeType.Rectangle });
            * 
            * var canvas = new Canvas();
            * canvas DrawShapes(shapes); 
            * 
            */
            
            
          
            
         // another way we can initialize shape 
            
            var shape1 = new Shape();       // Different strategy to get hold of the position
                                            //method 
            shape1.Width = 400;
            
         // shape1.Position.X = 20;     // this line will throw an exception if because 
                                        // Shape.Position method requres a position as input 
                                        // shape1 knows a method Position but it does not know what goes 
                                        // inside it while setting the value of X and Y 
           
            
            
            shape1.Position = new Position(40,20);  //Here we have used the constructor class
                                                    //to initialize the Position 
                                                    // We have to
            
            
            shape1.Position.Move(new Position(60, 40)); // Here we have used the Move method
                                                        // to move the method to new Position,
                                                        //move methods takes Position as
                                                        //the parameter 

            Console.WriteLine(shape1.Position.Y);  
        }
    }
}
