using Microsoft.Extensions.DependencyInjection;
using RegisterPersonApi.BLL.Services;
using RegisterPersonApi.BLL.Services.Interfaces;

namespace RegisterPersonApi.BLL.Extensions
{
    public static class BusinessLayerStartup
    {
        public static void AddBusinessLayer(this IServiceCollection services)
        {
            services.AddTransient<IJwtService, JwtService>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IPersonInformaitonService, PersonInformationService>();
            services.AddTransient<ISettlementService, SettlementService>();
            services.AddTransient<IImageFileService, ImageFileService>();
        }
    }
}
