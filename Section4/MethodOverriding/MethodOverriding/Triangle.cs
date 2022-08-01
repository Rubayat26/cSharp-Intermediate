using System;

namespace MethodOverriding
{
    public class Triangle : Shape       // here we could put the Triangle class in a 
                                        // sperate file 
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }
}