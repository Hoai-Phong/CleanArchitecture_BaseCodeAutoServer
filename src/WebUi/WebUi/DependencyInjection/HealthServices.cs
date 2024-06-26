using BaseCodeAutoSever.Infrastructure.Data;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace BaseCodeAutoSever.WebUi.DependencyInjection;

public class HealthServices : IServiceInstaller, IMiddlewareInstaller
{
    public void InstallerService(IServiceCollection services, IConfiguration configuration)
    {
        services.AddHealthChecks()
            .AddDbContextCheck<ApplicationDbContext>();
    }

    public void InstallMiddleWare(WebApplication app)
    {
        app.MapHealthChecks("/health");
    }
}