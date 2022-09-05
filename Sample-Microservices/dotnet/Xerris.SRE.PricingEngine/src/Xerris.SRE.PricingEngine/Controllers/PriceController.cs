using Microsoft.AspNetCore.Mvc;
using Serilog;
using Xerris.SRE.PricingEngine.Models;
using Xerris.SRE.PricingEngine.Repositories;

namespace Xerris.SRE.PricingEngine.Controllers;

[ApiController]
[Route("[controller]")]
public class PriceController : Controller
{
    private readonly IPriceRepository priceRepository;
    
    public PriceController(IPriceRepository priceRepository)
    {
        this.priceRepository = priceRepository;
    }

    [HttpGet("/prices",Name = "GetAllPrices")]
    public IEnumerable<Price> GetAllPrices() => priceRepository.All;

    [HttpGet("/prices/{sku:guid}",Name = "GetPriceBySku")]
    public Price GetPriceBySku(Guid sku)   
    {
        Log.Information("Fetching price for Product {@Sku}", sku);
        return priceRepository.FindBySku(sku);
    }
}