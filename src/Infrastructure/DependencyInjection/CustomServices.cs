using BaseCodeAutoSever.Application.Common.Services.DateTime;
using BaseCodeAutoSever.Application.Common.Services.Identity;
using BaseCodeAutoSever.Infrastructure.DateTime;
using BaseCodeAutoSever.Infrastructure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseCodeAutoSever.Infrastructure.DependencyInjection;

public sealed class CustomServices : IServiceInstaller
{
    public void InstallerService(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
    }
}