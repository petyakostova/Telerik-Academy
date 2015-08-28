namespace Document_System
{
    public class WordDocument : OfficeDocument, IDocument, IEncryptable
    {
        public WordDocument(string name, string content, long size, string version, int numberOfCharacters)
            :base(name, content, size, version)
        {
            this.NumberOfCharacters = numberOfCharacters;
            //this.IsEncrypted = false; // by default is false so no need
        }

        public int NumberOfCharacters { get; private set; }

        public bool IsEncrypted { get; private set; }   // encapsulation

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        //// override a vitrual method Information()
        //public override string Information()
        //{
        //    return base.Information() + " " + this.Version + " " + this.NumberOfCharacters;
        //    // base. invokes the method in the base class - that's the better way instead of:
        //    //return this.Name + " " + this.Content + " " + this.Size + " " + this.Version + " " + this.NumberOfCharacters;
        //}

        public override string GetInformation()
        {
            return this.Name + " " + this.Size;
        }
    }
}