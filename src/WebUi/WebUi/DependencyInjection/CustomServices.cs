using BaseCodeAutoSever.Infrastructure.Identity;
using BaseCodeAutoSever.WebUi.Client;
using BaseCodeAutoSever.WebUi.Components.Account;
using Microsoft.AspNetCore.Identity;

namespace BaseCodeAutoSever.WebUi.DependencyInjection;

public class CustomServices : IServiceInstaller
{
    public void InstallerService(IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();


        services.AddApplicationServerServices();
    }
}