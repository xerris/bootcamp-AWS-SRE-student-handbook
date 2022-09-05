using Xerris.SRE.PricingEngine.Models;

namespace Xerris.SRE.PricingEngine.Repositories;

public interface IPriceRepository
{
    IEnumerable<Price> All { get; }
    Price FindBySku(Guid sku);
}

public class PriceRepository : IPriceRepository
{
    public IEnumerable<Price> All => Prices;
    public Price FindBySku(Guid sku) => Prices.FirstOrDefault(x => x.Sku == sku);

    private static readonly List<Price> Prices = new()
    {
        new Price
        {
            Sku = new Guid("d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d"),
            RetailPrice = 5.75m,
            WholesalePrice = 3.00m
        },
        new Price
        {
            Sku = new Guid("c0c20648-ecd9-4896-999d-8c2d55010f77"),
            RetailPrice = 5.75m,
            WholesalePrice = 3.15m
        },
        new Price
        {
            Sku = new Guid("76ad06f0-8ced-401e-862d-da27b1b496bb"),
            RetailPrice = 4.25m,
            WholesalePrice = 2.50m
        }
    };
}