using System;
using Calculator.Business.Operators;
using Calculator.Business.Operators.Implementations;

namespace Calculator.Business.Factories.Implementations;

public class OperatorsFactory : IOperatorsFactory
{
    public IOperator CreateOperator(Models.Operators operatorName) =>
        operatorName switch
        {
            Models.Operators.Sum => new SumOperator(),
            Models.Operators.Subtract => new SubtractionOperator(),
            Models.Operators.Divide => new DivisionOperator(),
            Models.Operators.Multiply => new MultiplicationOperator(),
            _ => throw new ArgumentOutOfRangeException(nameof(operatorName), operatorName, $"Operation {operatorName} not exists")
        };
}