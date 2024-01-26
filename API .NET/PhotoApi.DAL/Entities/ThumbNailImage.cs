using System.ComponentModel.DataAnnotations.Schema;

namespace FilesAPI_20240123.Models
{
    public class ThumbNailImage
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int Size { get; set; }
        public byte[] Content { get; set; }

        [ForeignKey("ImageFileId")]
        public int ImageFileId { get; set; }
    }
}
