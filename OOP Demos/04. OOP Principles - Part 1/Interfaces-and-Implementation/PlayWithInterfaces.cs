using System;

class PlayWithInterfaces
{
    static void Main()
    {
        Square square = new Square(0, 0, 10);
        Rectangle rect = new Rectangle(0, 0, 10, 12);
        Circle circle = new Circle(0, 0, 5);
        if (square is IShape)
        {
            Console.WriteLine("{0} is IShape", square.GetType());   //Square is IShape
        }
        if (rect is IResizable)
        {
            Console.WriteLine("{0} is IResizable", rect.GetType()); //Rectangle is IResizable
        }
        if (circle is IResizable)
        {
            Console.WriteLine("{0} is IResizable", circle.GetType());
        }

        IShape[] shapes = { square, rect, circle };
        foreach (IShape shape in shapes)
        {
            shape.SetPosition(5, 5);
            Console.WriteLine("Type: {0};  surface: {1}", 
                shape.GetType(), shape.CalculateSurface());
        }
        //Type: Square;  surface: 100
        //Type: Rectangle;  surface: 120
        //Type: Circle;  surface: 78,5398163397448
    }
}
