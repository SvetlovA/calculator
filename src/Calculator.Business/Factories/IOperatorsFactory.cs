using Calculator.Business.Operators;

namespace Calculator.Business.Factories;

public interface IOperatorsFactory
{
    IOperator CreateSumOperator();
    IOperator CreateSubtractionOperator();
    IOperator CreateDivisionOperator();
    IOperator CreateMultiplicationOperator();
}