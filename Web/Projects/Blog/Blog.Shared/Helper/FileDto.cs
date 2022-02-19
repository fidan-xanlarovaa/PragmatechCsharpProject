namespace Blog.Shared.Helpers
{
    public class FileDto
    {
        public string FullName { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string SubDirectory { get; set; }
        public long Size { get; set; }
    }
}