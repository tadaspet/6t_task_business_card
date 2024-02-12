namespace RegisterPersonAPI.DTOs.Results
{
    public class PersonInfoResultDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModified { get; set; }
    }
}
