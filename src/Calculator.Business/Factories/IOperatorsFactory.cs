using Calculator.Business.Operators;

namespace Calculator.Business.Factories;

public interface IOperatorsFactory
{
    IOperator CreateOperator(Models.Operators operatorName);
}