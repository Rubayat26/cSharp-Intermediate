using System;

namespace AbstractClasses
{
    public class Circle : Shape
    {
        public override void Draw()    // if dont declared it will give error
                                       // so here forced to implement the Draw class
        {
            Console.WriteLine("Draw a circle");
        }
    }
}