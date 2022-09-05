using FluentAssertions;
using Moq;
using Xerris.DotNet.TestAutomation;
using Xerris.DotNet.TestAutomation.Factory;
using Xerris.SRE.ProductCatalog.Controllers;
using Xerris.SRE.ProductCatalog.Models;
using Xerris.SRE.ProductCatalog.Repositories;

namespace Xerris.SRE.ProductCatalog.Tests.Controllers;

[Collection("Models")]
public class ProductsControllerTests : MockBase
{
    private readonly Mock<IProductRepository> repository;
    private readonly ProductsController controller;

    public ProductsControllerTests()
    {
        repository = Strict<IProductRepository>();
        controller = new ProductsController(repository.Object);
    }

    [Fact]
    public void GetProducts()
    {
        var fromRepository = new List<Product>
        {
            FactoryGirl.Build<Product>(),
            FactoryGirl.Build<Product>(x => x.Name = "Hot Chocolate")
        };
        repository.Setup(x => x.All).Returns(fromRepository);

        var results = controller.Get();
        
        results.Should().NotBeNull();
    }

    [Fact]
    public void GetProductBySku()
    {
        var product = FactoryGirl.Build<Product>();
        repository.Setup(x => x.FindBySku(product.Sku)).Returns(product);
        controller.GetBySku(product.Sku).Should().NotBeNull();
    }
}