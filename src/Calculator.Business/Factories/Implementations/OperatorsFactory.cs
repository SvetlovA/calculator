using Calculator.Business.Operators;
using Calculator.Business.Operators.Implementations;

namespace Calculator.Business.Factories.Implementations;

public class OperatorsFactory : IOperatorsFactory
{
    public IOperator CreateSumOperator() => new SumOperator();

    public IOperator CreateSubtractionOperator() => new SubtractionOperator();

    public IOperator CreateDivisionOperator() => new DivisionOperator();

    public IOperator CreateMultiplicationOperator() => new MultiplicationOperator();
}