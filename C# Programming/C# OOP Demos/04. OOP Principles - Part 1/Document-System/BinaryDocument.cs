namespace Document_System
{
    public abstract class BinaryDocument : Document, IDocument
    {
        // Binary documents can have size (in bytes)... 

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

        //// we want fo change method's logic (the method is virtual)
        //public override string Information()
        //{                      
        //    return base.Information() + " " + this.Size;
        //    //return this.Name + " " + this.Content + " " + this.Size;
        //}

        //public new abstract string GetInformation();    // new, because we want to hide it
        //// when we have abstract method in some class, the class must be abstract too
        
    }
}