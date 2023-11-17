using System.ComponentModel.DataAnnotations;

namespace III._8.Databases._1.TaskFilePath.Database.Models
{
    public class Folder
    {
        [Key]
        public Guid FolderId { get; set; }
        public string FolderName { get; set; }
        public List<File> Files { get; set; }

    }
}


