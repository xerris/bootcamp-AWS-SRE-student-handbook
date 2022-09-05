using Xerris.SRE.ProductCatalog.Models;

namespace Xerris.SRE.ProductCatalog;

public interface IProductRepository {
    IEnumerable<Product> All { get; }
    Product FindBySku(Guid sku);
}

public class ProductRepository : IProductRepository
{
    private static readonly List<Product> Products = new List<Product>
    {
        new()
        {
            Sku = new Guid("d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d"),
            Name = "Flat White Latte",
            Description = "Our most popular Latte"  ,
            Manufacturer = "Coffee-Bucks"
        },
        new()
        {
            Sku = new Guid("c0c20648-ecd9-4896-999d-8c2d55010f77"),
            Name = "Pumpkin Spice Latte",
            Description = "Our favorite Latte for Halloween",
            Manufacturer = "Coffee-Bucks"
        },
        new()
        {
            Sku = new Guid("76ad06f0-8ced-401e-862d-da27b1b496bb"),
            Name = "Chocolate Fudge Brownee",
            Description = "Try our most popular Brownee",
            Manufacturer = "Jim Hortons"
        },
    };

    public IEnumerable<Product> All => Products;

    public Product FindBySku(Guid sku) => Products.FirstOrDefault(x => x.Sku == sku);
}