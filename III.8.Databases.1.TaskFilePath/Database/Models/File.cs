using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace III._8.Databases._1.TaskFilePath.Database.Models
{
    public class File
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double SizeMB { get; set; }
        public string Path { get; set; }
        //[ForeignKey("Folder")]
        //public Guid FolderId { get; set; }
        //public Folder Folder { get; set; }

    }
}