namespace Document_System
{
    public class OfficeDocument : BinaryDocument, IDocument
    {
        public OfficeDocument(string name, string content, long size, string version)
            :base(name, content, size)
        {
            this.Version = version;
        }

        public string Version { get; private set; }
    }
}