using KeepNotesDAL.Interfacees;
using KeepNotesDAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using TestingNotesDAL.Interfacees;
using TestingNotesDAL.Repositories;

namespace TestingNotesDAL.Extensions
{
    public static class ServiceCollectionDALExtensions
    {
        public static void AddDatabaseLayerServices(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<INoteRepository, NoteRepository>();
        }
    }
}
