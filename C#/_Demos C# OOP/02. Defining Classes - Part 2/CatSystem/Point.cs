namespace CatSystem
{
    // structure
    public struct Point
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public string GetCoordinates()
        {
            return string.Format("{0}, {1}", this.X, this.Y);
        }
    }
}