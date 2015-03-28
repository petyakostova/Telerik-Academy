namespace Document_System
{
    public abstract class Document : IDocument   // Ctrl+. => for implementing Name and Content
    {
        // constructor
        public Document(string name)
        {
            this.Name = name;
        }

        public Document(string name, string content)
            : this(name)    //invoke the other constructor
        {
            this.Content = content;
        }

        // automatic property, because we don't need validation
        public string Name { get; private set; }    // encapsulation - in the interface there is not set, because it's not public, so it must be private

        //// this is other way
        //private string name;    // private field
        //public string Name
        //{
        //    get { return this.name; }
        //}

        public string Content { get; private set; }

        //// virtual method, which returns string with information about the document
        //public virtual string Information()
        //{
        //    return this.Name + " " + this.Content;
        //}

        // abstract method => don't emplemented hier
        public abstract string GetInformation();        
    }
}