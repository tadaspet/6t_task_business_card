using III._8.Databases._1.TaskFilePath.Database;
using III._8.Databases._1.TaskFilePath.Database.Models;

namespace III._8.Databases._1.TaskFilePath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new FileContext();

            const string path = "C:\\NETUA2 class exercises";

            var fileData = new FileRead();
            fileData.GetFileInfo(path);

            dbContext.Files.AddRange(fileData.Files);
            dbContext.SaveChanges();

            dbContext.Folders.AddRange(fileData.Folders);
            dbContext.SaveChanges();

        }
    }
}


