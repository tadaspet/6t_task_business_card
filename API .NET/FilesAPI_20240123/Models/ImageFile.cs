using System.ComponentModel.DataAnnotations.Schema;

namespace FilesAPI_20240123.Models
{
    public class ImageFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public byte[] Content { get; set; }
        public ThumbNailImage ThumbNail { get; set; }
    }
}
