using FilesAPI_20240123.Models;

namespace FilesAPI_20240123.Database
{
    public interface IDbThumbNailRepository
    {
        int AddThumbNail(ThumbNailImage thumbNail);
        void DeleteAddThumbNail(int id);
        ThumbNailImage GetAddThumbNail(int id);
    }
}