namespace Document_System
{
    public class BinaryDocument : Document, IDocument
    {
        // Binary documents can have size (in bytes). 

        public BinaryDocument(string name, long size)
            :base(name)
        {
            this.Size = size;
        }

        public BinaryDocument(string name, string content, long size)
            : base(name, content)    // invoke the base constructor and set the name and the content
        {
            this.Size = size;
        }

        public long Size { get; private set; }  // encapsulation
        // must be added constructor too
    }
}