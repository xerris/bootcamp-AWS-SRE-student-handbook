using FluentAssertions;
using Moq;
using Xerris.DotNet.TestAutomation;
using Xerris.DotNet.TestAutomation.Factory;
using Xerris.SRE.ProductCatalog.Controllers;
using Xerris.SRE.ProductCatalog.Models;
using Xerris.SRE.ProductCatalog.Repositories;
using Xerris.SRE.ProductCatalog.Services;

namespace Xerris.SRE.ProductCatalog.Tests.Controllers;

[Collection("Models")]
public class ProductsControllerTests : MockBase
{
    private readonly Mock<IProductService> service;
    private readonly ProductsController controller;

    public ProductsControllerTests()
    {
        service = Strict<IProductService>();
        controller = new ProductsController(service.Object);
    }

    [Fact]
    public async Task GetProducts()
    {
        var fromRepository = new List<Product>
        {
            FactoryGirl.Build<Product>(),
            FactoryGirl.Build<Product>(x => x.Name = "Hot Chocolate")
        };
        service.Setup(x => x.GetAllProducts())
               .ReturnsAsync(fromRepository);

        var results = await controller.GetAllProducts();
        
        results.Should().NotBeNull();
    }

    [Fact]
    public async Task GetProductBySku()
    {
        var product = FactoryGirl.Build<Product>();
        service.Setup(x => x.FindBySku(product.Sku)).ReturnsAsync(product);
        var found = await controller.GetBySku(product.Sku);
        found.Should().NotBeNull();
    }
}