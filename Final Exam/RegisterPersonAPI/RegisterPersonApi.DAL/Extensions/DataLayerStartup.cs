using Microsoft.Extensions.DependencyInjection;
using RegisterPersonApi.DAL.Repositories;
using RegisterPersonApi.DAL.Repositories.Interfaces;

namespace RegisterPersonApi.DAL.Extensions
{
    public static class DataLayerStartup
    {
        public static void AddDataLayer(this IServiceCollection services)
        {
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IPersonInformationRepository, PersonInformationRepository>();
            services.AddScoped<ISettlementRepository, SettlementRepository>();
            services.AddScoped<IImageFileRepository, ImageFileRepository>();
        }
    }
}
