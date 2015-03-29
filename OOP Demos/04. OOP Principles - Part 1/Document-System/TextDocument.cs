namespace Document_System
{
    public abstract class TextDocument : Document, IDocument   // first class, then interfaces, separated by commas
    {
        // Name and Content are already implemented in Document => TextDocument inherits Document

        //constructor
        public TextDocument(string name, string charset)    // in the base class the name is mandatory so its first (because it's in base)
            : base(name) // invoke the base constructor
        {
            this.Charset = charset;
        }

        // this constructor is not mandatory, because the content is not mandatory
        public TextDocument(string name, string content, string charset)
            : base(name, content)   //invoke the base constructor
        {
            this.Charset = charset;
        }

        //we don't have given interface for charset, so we should guess what it should be => utf8=> string
        public string Charset { get; private set; } //encapsulation again
        // Charset is already implemented, but we should implemented a constructor too

        //// implement the method GetInformation()
        //public override string GetInformation()
        //{
        //    return this.Name + " " + this.Content;
        //}
    }
}
