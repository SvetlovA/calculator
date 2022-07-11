using Calculator.Business.Models;

namespace Calculator.Business.Operators.Implementations;

internal class SubtractionOperator : IOperator
{
    public ResultData Calculate(decimal lefItem, decimal rightItem)
    {
        return new ResultData
        {
            Result = lefItem - rightItem
        };
    }
}