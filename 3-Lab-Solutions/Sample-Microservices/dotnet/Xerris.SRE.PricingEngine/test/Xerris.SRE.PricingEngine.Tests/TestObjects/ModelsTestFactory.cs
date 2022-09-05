using Xerris.DotNet.Core.Extensions;
using Xerris.DotNet.TestAutomation.Factory;

namespace Xerris.SRE.PricingEngine.Tests.TestObjects;

public sealed class ModelsTestFixture : IDisposable
{
    public ModelsTestFixture()
    {
        new ClearFactory()
            .Then(new ModelFactory())
            .Run();
    }

    public void Dispose()
    {
        FactoryGirl.Clear();
    }
}

[CollectionDefinition("Models")]
public class ModelCollection : ICollectionFixture<ModelsTestFixture>
{
}