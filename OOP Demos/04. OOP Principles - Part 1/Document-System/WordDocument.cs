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
    }
}