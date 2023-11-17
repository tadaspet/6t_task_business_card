using System.ComponentModel.DataAnnotations;


namespace Task1
{
    public class File
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }    
    }
}