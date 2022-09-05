using Serilog;
using Xerris.DotNet.Core;

namespace Xerris.SRE.ProductCatalog;

public class AppStartup : IAppStartup
{
    public IConfiguration StartUp(IServiceCollection collection)
    {
        var builder = new ApplicationConfigurationBuilder<ApplicationConfig>();
        var appConfig = builder.Build();

        collection.AddSingleton<IApplicationConfig>(appConfig);
        collection.AutoRegister(GetType().Assembly);
        return builder.Configuration;
    }

    public void InitializeLogging(IConfiguration configuration, Action<IConfiguration> defaultConfig)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console(outputTemplate:
                "[{Timestamp:HH:mm:ss} {Level}] {Message:lj}{NewLine}{Exception}")
            .CreateLogger();
    }
}