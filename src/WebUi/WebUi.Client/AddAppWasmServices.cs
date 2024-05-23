using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BaseCodeAutoSever.WebUi.Client.Handlers.Interfaces;
using BaseCodeAutoSever.WebUi.Client.Handlers.ServerImplementation;

namespace BaseCodeAutoSever.WebUi.Client;

public static class AppServices
{
    public static WebAssemblyHostBuilder AddApplicationWebAssemblyServices(this WebAssemblyHostBuilder builder)
    {
        builder.Services.AddHttpClient("BaseCodeAutoSever.WebUi", client =>
            client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
        
        builder.Services.AddScoped(sp => 
            sp.GetRequiredService<IHttpClientFactory>().CreateClient("BaseCodeAutoSever.WebUi"));

        builder.Services.Scan(scan => scan
            .FromAssemblyOf<ITodoListsClient>()
            .AddClasses()
            .AsImplementedInterfaces()
            .WithScopedLifetime());

        return builder;
    }
    
    public static IServiceCollection AddApplicationServerServices(this IServiceCollection services)
    {
        services.AddScoped<IUserHandler, UserServerHandler>();
        services.AddScoped<ITodoListHandler, TodoListServerHandler>();
        services.AddScoped<ITodoItemsHandler, TodoItemsServerHandler>();
        
        return services;
    }
}
