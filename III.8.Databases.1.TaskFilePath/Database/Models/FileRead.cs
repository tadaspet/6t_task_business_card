namespace III._8.Databases._1.TaskFilePath.Database.Models
{
    public class FileRead
    {
        public string PathName { get; set; }
        public List<File> Files { get; set; } = new List<File>();
        public List<Folder> Folders { get; set; } = new List<Folder>();


        public void GetFileInfo(string path)
        {
            if (Directory.Exists(path))
            {

                string[] folders = Directory.GetDirectories(path);

                foreach (string folder in folders)
                {
                    DirectoryInfo folderInfo = new DirectoryInfo(folder);
                    var folderObject = new Folder
                    {
                        FolderId = Guid.NewGuid(),
                        FolderName = folderInfo.Name,
                        Files = new List<File>(),
                    };

                    string[] files = Directory.GetFiles(folder);
                    foreach (string file in files)
                    {
                        FileInfo fileInfo = new FileInfo(file);
                        folderObject.Files.Add(new File
                        {
                            Id = Guid.NewGuid(),
                            Name = fileInfo.Name,
                            SizeMB = (double)fileInfo.Length / (1024 * 1024),
                            Path = fileInfo.FullName,
                        });
                    }
                    Folders.Add(folderObject);
                    GetFileInfo(folder);
                }
            }
        }
    }
}
