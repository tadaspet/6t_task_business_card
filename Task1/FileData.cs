namespace Task1
{
    public class FileData
    {
        public string PathName { get; set; }
        public List<File> Files { get; set; }

        public FileData(string path) 
        {
            PathName = path;
        }
        public void GetFileInfo()
        {
            Files = new List<File>();
            if (Directory.Exists(PathName)) 
            {
                string[] files = Directory.GetFiles(PathName);
                    
                foreach(string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Files.Add(new File
                    {
                        Id = Guid.NewGuid(),
                        Name = fileInfo.Name,
                        Size = fileInfo.Length,
                        Path = fileInfo.FullName,
                    });
                }
            }
        }
    }
}