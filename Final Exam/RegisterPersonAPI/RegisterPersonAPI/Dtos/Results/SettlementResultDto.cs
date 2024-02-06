namespace RegisterPersonAPI.Dtos.Results
{
    public class SettlementResultDto
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public string? FlatNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
