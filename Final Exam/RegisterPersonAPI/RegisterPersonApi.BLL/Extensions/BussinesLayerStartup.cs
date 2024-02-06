using Microsoft.Extensions.DependencyInjection;
using RegisterPersonApi.BLL.Services;
using RegisterPersonApi.BLL.Services.Interfaces;

namespace RegisterPersonApi.BLL.Extensions
{
    public static class BussinesLayerStartup
    {
        public static void AddBussinessLayer(this IServiceCollection services)
        {
            services.AddTransient<IJwtService, JwtService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IPersonInformaitonService, PersonInformaitonService>();
            services.AddTransient<ISettlementService, SettlementService>();
        }
    }
}
