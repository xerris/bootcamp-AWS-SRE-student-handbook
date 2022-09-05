using Refit;
using Serilog;
using Xerris.DotNet.Core;
using Xerris.SRE.ProductCatalog.Services;

namespace Xerris.SRE.ProductCatalog;

public class AppStartup : IAppStartup
{
    public IConfiguration StartUp(IServiceCollection collection)
    {
        var builder = new ApplicationConfigurationBuilder<ApplicationConfig>();
        var appConfig = builder.Build();

        collection.AddRefitClient<IPricingApi>()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri(appConfig.PricingApiUri));        
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