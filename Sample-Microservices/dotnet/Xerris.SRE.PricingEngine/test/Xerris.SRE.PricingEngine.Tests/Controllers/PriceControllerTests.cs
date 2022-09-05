using FluentAssertions;
using Moq;
using Xerris.DotNet.TestAutomation;
using Xerris.DotNet.TestAutomation.Factory;
using Xerris.SRE.PricingEngine.Controllers;
using Xerris.SRE.PricingEngine.Models;
using Xerris.SRE.PricingEngine.Repositories;

namespace Xerris.SRE.PricingEngine.Tests.Controllers;

[Collection("Models")]
public class PriceControllerTests : MockBase
{
    private readonly Mock<IPriceRepository> repository;
    private readonly PriceController controller;

    public PriceControllerTests()
    {
        repository = Strict<IPriceRepository>();
        controller = new PriceController(repository.Object);
    }

    [Fact]
    public void GetPriceBySku()
    {
        var product = FactoryGirl.Build<Price>();
        repository.Setup(x => x.FindBySku(product.Sku)).Returns(product);
        controller.GetPriceBySku(product.Sku).Should().NotBeNull();
    }
}