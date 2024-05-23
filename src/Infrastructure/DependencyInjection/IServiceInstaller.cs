using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BaseCodeAutoSever.Infrastructure.DependencyInjection;

public interface IServiceInstaller
{
    void InstallerService(IServiceCollection services, IConfiguration configuration);
}