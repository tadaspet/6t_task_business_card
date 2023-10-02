using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class FileReader
    {
        public string FilePath { get; set; }
        //public FileReader (string path)
        //{
        //    FilePath = path;
        //}
        public void ReadFile()
        {
            using (var sr = new StreamReader(FilePath));
        }
    }
}
