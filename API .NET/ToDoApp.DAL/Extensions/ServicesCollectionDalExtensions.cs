using Microsoft.Extensions.DependencyInjection;
using ToDoApp.DAL.Interfaces;
using ToDoApp.DAL.Repositories;

namespace ToDoApp.DAL.Extensions
{
    public static class ServicesCollectionDalExtensions
    {
        public static void AddDataBaseServices(this IServiceCollection services)
        {
            services.AddTransient<ITodoRepository, TodoRepository>();
            //cia reikia prideti kitus DAL repositorius
        }
    }
}
