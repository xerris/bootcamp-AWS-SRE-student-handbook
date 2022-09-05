using Microsoft.DotNet.PlatformAbstractions;
using Xerris.SRE.ProductCatalog.Models;
using Xerris.SRE.ProductCatalog.Repositories;

namespace Xerris.SRE.ProductCatalog.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> FindBySku(Guid sku);
}

public class ProductService : IProductService
{
    private readonly IProductRepository repository;
    private readonly IPricingApi pricingApi;

    public ProductService(IProductRepository repository, IPricingApi pricingApi)
    {
        this.repository = repository;
        this.pricingApi = pricingApi;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        var products = repository.All;
        var prices = await pricingApi.GetPrices();
        return Combine(products, prices);
    }

    public async Task<Product> FindBySku(Guid sku)
    {
        var product = repository.FindBySku(sku);
        var price = await pricingApi.FindBySku(sku);
        return product.SetPrice(price);
    }

    private static IEnumerable<Product> Combine(IEnumerable<Product> products, IEnumerable<Price> prices)
    {
        return from p in products
            join pr in prices
                on p.Sku equals pr.Sku
            select p.SetPrice(pr);
    }
}