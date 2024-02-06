using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterPersonApi.DAL.Entities
{
    public class Settlement
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public string? FlatNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModified { get; set; }
        public int PersonInformationId { get; set; }
        [ForeignKey("PersonInformationId")]
        public PersonInformation PersonInformation { get; set; }
    }
}
