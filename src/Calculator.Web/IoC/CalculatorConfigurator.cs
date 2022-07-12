using Calculator.Business.Factories;
using Calculator.Business.Factories.Implementations;
using Calculator.Business.Models;
using Calculator.Business.Operators;
using Calculator.Web.Models;

namespace Calculator.Web.IoC;

//public delegate IOperator ServiceResolver(Operators calculatorOperator);

public static class CalculatorConfigurator
{
    public static void Configure(IServiceCollection serviceCollection)
    {
        //serviceCollection.AddSingleton<ServiceResolver>(serviceProvider => calculatorOperator =>
        //{
        //    return calculatorOperator switch
        //    {
        //        Operators.Sum => serviceProvider.GetRequiredService<>(),
        //        Operators.Subtract => expr,
        //        Operators.Divide => expr,
        //        Operators.Multiply => expr,
        //        _ => throw new ArgumentOutOfRangeException(nameof(calculatorOperator), calculatorOperator, null)
        //    }
        //})

        serviceCollection.AddSingleton<IOperatorsFactory, OperatorsFactory>();
    }
}