using System;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle"); //Any code specifice tho the circle class 
           // base.Draw();         //here we can pass the execution to the base draw method
        }
    }

    public class Rectangle : Shape     // we can put the reacntagle class
                                       // in a seperate file, so the Shape class 
                                       // would not get fat 
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}





//Here if we try to get set Position, we cannot not just pass in integers, we have 
// pass and get Positions, thats why I created the constructor class inside Position.cs 