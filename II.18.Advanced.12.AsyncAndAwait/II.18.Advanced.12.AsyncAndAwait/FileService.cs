using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace II._18.Advanced._12.AsyncAndAwait
{
    internal class FileService
    {
        const string path = "csharp.txt";
        public async Task<string> ReadTextFromFileAsync()
        {
            try
            {
                await Task.Delay(5000);
                var content = await File.ReadAllTextAsync(path);
                return content;
            }
            catch (Exception)
            {
                return "File was not teaded!";
            }
        }
    }
}
