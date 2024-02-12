namespace RegisterPersonAPI.DTOs.Results
{
    public class ImageFileResultDto
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
