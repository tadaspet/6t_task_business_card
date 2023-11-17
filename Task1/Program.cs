using Microsoft.EntityFrameworkCore;
using System;
using System.IO;


namespace Task1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new FileContext();

            const string path = "C:\\Users\\petru\\Desktop\\NETUA2\\1.Lygis Basic";

            var fileData = new FileData(path);
            fileData.GetFileInfo();

            dbContext.Files.AddRange(fileData.Files);
        }
    }
}