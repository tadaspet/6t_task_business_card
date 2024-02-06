using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterPersonApi.DAL.Entities
{
    public class ImageFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public int Size { get; set; }
        public byte[] Content { get; set; }
        public DateTime CreationDate { get; set; }
        public int PersonInformationId { get; set; }
        [ForeignKey("PersonInformationId")]
        public PersonInformation PersonInformation { get; set; }
    }
}
