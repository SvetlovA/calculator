using Calculator.Business.Models;

namespace Calculator.Business.Operators.Implementations;

internal class DivisionOperator : IOperator
{
    public ResultData Calculate(decimal lefItem, decimal rightItem)
    {
        return new ResultData
        {
            Result = lefItem / rightItem
        };
    }
}