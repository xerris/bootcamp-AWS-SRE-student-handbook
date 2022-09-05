using Microsoft.AspNetCore.Mvc;
using Serilog;
using Xerris.SRE.ProductCatalog.Models;
using Xerris.SRE.ProductCatalog.Repositories;

namespace Xerris.SRE.ProductCatalog.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : Controller
{
    private readonly IProductRepository productRepository;
    
    public ProductsController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet(Name = "GetProducts")]
    public IEnumerable<Product> Get()
    {
        Log.Information("Fetching all Products");
        return productRepository.All;
    }
    
    [HttpGet("/{sku}",Name = "GetProductBySku")]
    public Product GetBySku(Guid sku)   
    {
        Log.Information("Fetching Product {@Sku}", sku);
        return productRepository.FindBySku(sku);
    }
}