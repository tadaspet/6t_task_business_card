using FilesAPI_20240123.Database;
using FilesAPI_20240123.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace FilesAPI_20240123.Services
{
    public class ThumbNailServices : IThumbNailServices
    {
        private readonly IDbThumbNailRepository _dbThumbNailRepository;

        public ThumbNailServices(IDbThumbNailRepository dbRepository)
        {
            _dbThumbNailRepository = dbRepository;
        }

        public int AddThumbNailFile(ThumbNailImage thumbnailFile)
        {
            return _dbThumbNailRepository.AddThumbNail(thumbnailFile);
        }

        public ThumbNailImage GetThumbNailFile(int id)
        {
            return _dbThumbNailRepository.GetAddThumbNail(id);
        }
        public byte[] CreateThumbnail(Bitmap originalImage, int width, int height)
        {
            using var thumbnail = originalImage.GetThumbnailImage(width, height, null, IntPtr.Zero);
            using var outputStream = new MemoryStream();
            thumbnail.Save(outputStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            return outputStream.ToArray();
        }
    }
}
