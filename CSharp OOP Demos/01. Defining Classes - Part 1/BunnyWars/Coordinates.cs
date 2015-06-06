namespace Bunnies
{
    public class Coordinates
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Coordinates() : this(0, 0)
        {

        }

        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
