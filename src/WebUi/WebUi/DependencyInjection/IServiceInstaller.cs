namespace BaseCodeAutoSever.WebUi.DependencyInjection;

public interface IServiceInstaller
{
    void InstallerService(IServiceCollection services, IConfiguration configuration);
}