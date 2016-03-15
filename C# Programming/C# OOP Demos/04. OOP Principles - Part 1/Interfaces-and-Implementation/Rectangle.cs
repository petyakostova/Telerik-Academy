public struct Rectangle : IShape, IMovable, IResizable
{
    private int x, y, width, height;

    public Rectangle(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public void SetPosition(int x, int y)   // implementation of the method SetPosition()
    {
        this.x = x;
        this.y = y;
    }

    public double CalculateSurface()    // implementation of the method CalculateSurface()
    {
        return width * height;
    }

    public void Move(int deltaX, int deltaY) // From IMovable 
    {
        this.x += deltaX;
        this.y += deltaY;
    }

    public void Resize(int weightX, int weightY) // IResizable 
    {
        width = width * weightX;
        height = height * weightY;
    }

    public void ResizeByX(int weightX) // From IResizable 
    {
        width = width * weightX;
    }

    public void ResizeByY(int weightY) // From IResizable 
    {
        height = height * weightY;
    }
}
