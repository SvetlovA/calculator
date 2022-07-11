using Calculator.Business.Factories;
using Calculator.Business.Factories.Implementations;

namespace Calculator.Web.IoC;

public static class CalculatorConfigurator
{
    public static void Configure(IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IOperatorsFactory, OperatorsFactory>();
    }
}