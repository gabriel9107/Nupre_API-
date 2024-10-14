namespace Nupre_API.DTOs
{
    public class FileToDownload
    {
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public byte[] FileContent { get; set; } = null!;
    }
}
