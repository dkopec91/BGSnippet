using System;

namespace BGSnippet
{
    //I want my config as static app-wide class
    //but I also want to be able to serialize it
    //therefore non static config class has been created
    //not most elegant solution, I know
    //TODO: reconsider non static config class approach

    [Serializable]
    public class SerializableConfig
    {
        public string SourceFilePath { get; set; }
        public string SourceFileName { get; set; }
        public string TargetFilePath { get; set; }
        public string TargetFileName { get; set; }
        public int SnippetWitdth { get; set; }
        public int SnippetHeight { get; set; }
        public int SnippetLeft { get; set; }
        public int SnippetTop { get; set; }
        public int Delay { get; set; }
    }

}
