using Refit;
using Xerris.SRE.ProductCatalog.Models;

namespace Xerris.SRE.ProductCatalog.Services;

public interface IPricingApi
{
    [Get("/prices")]
    Task<IEnumerable<Price>> GetPrices();

    [Get("/prices/{sku}")]
    Task<Price> FindBySku(Guid sku);
}