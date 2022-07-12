using Calculator.Business.Factories;
using Calculator.Business.Models;
using Calculator.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly IOperatorsFactory _operatorsFactory;

        public CalculatorController(IOperatorsFactory operatorsFactory)
        {
            _operatorsFactory = operatorsFactory;
        }

        [HttpPost("Calculate")]
        public CalculatorResponse Calculate(CalculatorRequest calculatorRequest) =>
            GetCalculatorResponse(calculatorRequest);

        private CalculatorResponse GetCalculatorResponse(CalculatorRequest calculatorRequest)
        {
            var calculatorOperatorType = Enum.Parse<Operators>(calculatorRequest.Operator);

            var calculatorOperator = _operatorsFactory.CreateOperator(calculatorOperatorType);

            var leftItem = decimal.Parse(calculatorRequest.LeftItem);
            var rightItem = decimal.Parse(calculatorRequest.RightItem);

            var calculationResult = calculatorOperator.Calculate(leftItem, rightItem);

            return new CalculatorResponse
            {
                Result = calculationResult.Result
            };
        }
    }
}