using Xerris.DotNet.Core;

namespace Xerris.SRE.ProductCatalog;

public interface IApplicationConfig
{
    string PricingApiUri { get; }
}

public class ApplicationConfig : IApplicationConfig, IApplicationConfigBase
{
    public string PricingApiUri { get; set; }
}
