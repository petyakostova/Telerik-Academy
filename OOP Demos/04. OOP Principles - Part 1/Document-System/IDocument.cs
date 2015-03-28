namespace Document_System
{
    public interface IDocument
    {
        // there is no need to white public, because by default all in the interface is public
        string Name { get; }
        string Content { get; }
        string ToString();
    }
}