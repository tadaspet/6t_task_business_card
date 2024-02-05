using KeepNotesDAL.Entities;
using TestingNotesApiBLL.Interfaces;
using TestingNotesDAL.Interfacees;

namespace KeepNotesApiBLL.Services
{
    public class ImageFilesServices : IImageFilesServices
    {
        private readonly IImageRepository _dbRepository;

        public ImageFilesServices(IImageRepository dbRepository)
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
        public ImageFile GetByImageIdAndUser (int imageId, int userId) 
        {
            return _dbRepository.GetByImageIdAndUser(imageId, userId);
        }
    }
}
