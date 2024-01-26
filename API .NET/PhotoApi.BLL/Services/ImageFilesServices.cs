using FilesAPI_20240123.Models;
using PhotoApi.BLL.Interfaces;
using PhotoApi.DAL.Interfaces;

namespace FilesAPI_20240123.Services
{
    public class ImageFilesServices : IImageFilesService
    {
        private readonly IDbRepository _dbRepository;

        public ImageFilesServices(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        /// <summary>
        /// Returns Object Id property
        /// </summary>
        /// <param name="imageFile"></param>
        /// <returns>int Id</returns>
        public int AddImageFile(ImageFile imageFile)
        {
            return _dbRepository.AddImageFile(imageFile);
        }

        /// <summary>
        /// Returns Image File by Id ImageFileServices
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ImageFile object</returns>
        public ImageFile GetImageFile(int id)
        {
            return _dbRepository.GetImageFile(id);
        }
    }
}
