using Xerris.DotNet.Core.Commands;
using Xerris.DotNet.TestAutomation.Factory;
using Xerris.SRE.PricingEngine.Models;

namespace Xerris.SRE.PricingEngine.Tests.TestObjects;

public class ModelFactory : ICommand
{
    public void Run()
    {
        FactoryGirl.Define(() => new Price
        {
            Sku = Guid.NewGuid(),
            RetailPrice = 5.75m,
            WholesalePrice = 3.00m,
        });
    }
}