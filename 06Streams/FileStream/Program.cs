namespace FileStreamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("paragraph.txt");
            File.WriteAllText("path.txt", content);
            string fileStreamLine = "";
            using (var readFileStream = new FileStream("path.txt", FileMode.Open, FileAccess.Read, FileShare.Read)) ;
            {
                while(fileStreamLine != null)
                {

                }
            }        
        }
    }
}