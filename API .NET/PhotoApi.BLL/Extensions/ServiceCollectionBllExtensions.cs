using FilesAPI_20240123.Database;
using FilesAPI_20240123.Services;
using Microsoft.Extensions.DependencyInjection;
using PhotoApi.BLL.Interfaces;
using PhotoApi.DAL.Interfaces;

namespace PhotoApi.DAL.Extensions
{
    public static class ServiceCollectionBllExtensions
    {
        public static void AddBllExtensionServices(this IServiceCollection services)
        {
            services.AddTransient<IImageFilesService, ImageFilesServices>();
            services.AddTransient<IThumbNailServices, ThumbNailServices>();
        }
    }
}
