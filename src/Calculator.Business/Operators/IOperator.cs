using Calculator.Business.Models;

namespace Calculator.Business.Operators;

public interface IOperator
{
    ResultData Calculate(decimal lefItem, decimal rightItem);
}