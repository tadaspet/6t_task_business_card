using KeepNotesApiBLL.Services;
using Microsoft.Extensions.DependencyInjection;
using TestingNotesApiBLL.Interfaces;
using TestingNotesApiBLL.Services;

namespace TestingNotesApiBLL.Extensions
{
    public static class ServiceCollectionBLLExtensions
    {
        public static void AddBussinessLogicServices(this IServiceCollection services)
        {
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IJwtService, JwtService>();
            services.AddTransient<IImageFilesServices, ImageFilesServices>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<INoteServices, NoteServices>();
        }
    }
}
