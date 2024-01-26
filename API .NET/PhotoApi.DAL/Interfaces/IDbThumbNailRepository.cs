using FilesAPI_20240123.Models;

namespace PhotoApi.DAL.Interfaces
{
    public interface IDbThumbNailRepository
    {
        int AddThumbNail(ThumbNailImage thumbNail);
        void DeleteAddThumbNail(int id);
        ThumbNailImage GetAddThumbNail(int id);
    }
}