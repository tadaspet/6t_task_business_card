using TestingNotesApi.Interfaces;
using TestingNotesApi.Mappers;

namespace TestingNotesDAL.Extensions
{
    public static class ServiceCollectionApi
    {
        public static void AddMapperServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryMapper, CategoryMapper>();
            services.AddTransient<INoteMapper, NoteMapper>();
            services.AddTransient<IImageFileMapper, ImageFileMapper>();
        }
    }
}