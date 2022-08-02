using System;

namespace AbstractClasses
{
    public abstract class Shape  // to hold a abstract method the class needs to be
                                 // abstract as well
    {
        public int Width { get; set; }    // common properties for all derived classes
        public int Height { get; set; }

        public abstract void Draw();  // Abstract method does not have body

        public void Copy()         // common methods for all derived classes
        {
            Console.WriteLine("Copy shape into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}