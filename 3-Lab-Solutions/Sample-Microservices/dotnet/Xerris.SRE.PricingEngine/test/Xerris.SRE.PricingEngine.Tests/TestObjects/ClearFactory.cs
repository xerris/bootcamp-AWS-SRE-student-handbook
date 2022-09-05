using Xerris.DotNet.Core.Commands;
using Xerris.DotNet.TestAutomation.Factory;

namespace Xerris.SRE.PricingEngine.Tests.TestObjects;

public class ClearFactory : ICommand
{
    public void Run()
    {
        FactoryGirl.Clear();
    }
}