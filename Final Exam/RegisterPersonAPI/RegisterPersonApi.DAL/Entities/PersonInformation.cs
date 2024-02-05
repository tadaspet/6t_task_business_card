using System.ComponentModel.DataAnnotations.Schema;

namespace RegisterPersonApi.DAL.Entities
{
    public class PersonInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModified { get; set; }
        public ImageFile Photo { get; set; }
        public Settlement Settlement { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}