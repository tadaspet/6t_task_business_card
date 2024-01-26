using Microsoft.Extensions.DependencyInjection;
using ToDoApp.BLL.Interfaces;
using ToDoApp.BLL.Services;

namespace ToDoApp.BLL.Extensions
{
    public static class ServiceCollectionBllExtensions
    {
        public static void AddBussinessLogic(this IServiceCollection services)
        {
            services.AddTransient<IEmailServices, EmailServices>();
            //cia reikai prideti ir kitus BLL servisus
        }
    }
}
