using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)  //Here we are using the point object from line 5  
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation"); //throwing an exception error  //defencive programming

            Move(newLocation.X, newLocation.Y); //here we are calling the move method from line 16, this way we are not rewriting the same concept twice in the code 
        }
    }
}
