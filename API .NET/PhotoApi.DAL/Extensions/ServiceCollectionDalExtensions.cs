using FilesAPI_20240123.Database;
using Microsoft.Extensions.DependencyInjection;
using PhotoApi.DAL.Interfaces;

namespace PhotoApi.DAL.Extensions
{
    public static class ServiceCollectionDalExtensions
    {
        public static void AddDataBaseExtensionServices(this IServiceCollection services)
        {
            services.AddTransient<IDbRepository, DbRepository>();
            services.AddTransient<IDbThumbNailRepository, DbThumbNailRepository>();
        }
    }
}
