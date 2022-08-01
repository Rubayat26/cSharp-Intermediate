namespace MethodOverriding
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        


        public Position (int x, int y)   // to take integer values as input we need this co
        {
            X = x;
            Y = y;
        }

        public void Move(Position newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
            
    }
}