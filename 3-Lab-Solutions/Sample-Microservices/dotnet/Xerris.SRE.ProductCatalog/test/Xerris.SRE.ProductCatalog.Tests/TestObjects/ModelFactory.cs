using Xerris.DotNet.Core.Commands;
using Xerris.DotNet.TestAutomation.Factory;
using Xerris.SRE.ProductCatalog.Models;

namespace Xerris.SRE.ProductCatalog.Tests.TestObjects;

public class ModelFactory : ICommand
{
    public void Run()
    {
        FactoryGirl.Define(() => new Product
        {
            Sku = Guid.NewGuid(),
            Name = "Latte",
            Description = "Latte",
            Manufacturer = "Mr. Coffee"
        });
    }
}