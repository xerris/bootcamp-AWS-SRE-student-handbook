using Microsoft.AspNetCore.Mvc;
using Serilog;
using Xerris.SRE.ProductCatalog.Models;
using Xerris.SRE.ProductCatalog.Repositories;
using Xerris.SRE.ProductCatalog.Services;

namespace Xerris.SRE.ProductCatalog.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : Controller
{
    private readonly IProductService service;
    
    public ProductsController(IProductService service)
    {
        this.service = service;
    }

    [HttpGet(Name = "GetProducts")]
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        Log.Information("Fetching all Products");
        return await service.GetAllProducts();
    }
    
    [HttpGet("/{sku:guid}",Name = "GetProductBySku")]
    public async Task<Product> GetBySku(Guid sku)   
    {
        Log.Information("Fetching Product {@Sku}", sku);
        return await service.FindBySku(sku);
    }
}