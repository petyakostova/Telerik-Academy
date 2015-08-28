// instance class
public class Turtle : Animal
{
    // implement the abstract methods in Animal
    public override int Speed
    {
        get
        {
            return 1;
        }
    }

    public override string GetName()
    {
        return "turtle";
    }
}
