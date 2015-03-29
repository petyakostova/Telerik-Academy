namespace Document_System
{
    public interface IDocument
    {
        // there is no need to white public, because by default all in the interface is public
        // properties
        string Name { get; }
        string Content { get; }
        // methods
        string GetInformation();    // the method must be implemented in all classes, that inherits IDocument
        string ToString();
    }
}