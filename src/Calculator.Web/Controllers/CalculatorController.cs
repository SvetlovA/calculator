using Calculator.Business.Factories;
using Calculator.Business.Operators;
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

        [HttpPost("Sum")]
        public CalculatorResponse Sum(CalculatorRequest calculatorRequest)
        {
            var calculatorOperator = _operatorsFactory.CreateSumOperator();
            return GetCalculatorResponse(calculatorOperator, calculatorRequest);
        }

        [HttpPost("Subtract")]
        public CalculatorResponse Subtract(CalculatorRequest calculatorRequest)
        {
            var calculatorOperator = _operatorsFactory.CreateSubtractionOperator();
            return GetCalculatorResponse(calculatorOperator, calculatorRequest);
        }

        [HttpPost("Divide")]
        public CalculatorResponse Divide(CalculatorRequest calculatorRequest)
        {
            var calculatorOperator = _operatorsFactory.CreateDivisionOperator();
            return GetCalculatorResponse(calculatorOperator, calculatorRequest);
        }

        [HttpPost("Multiply")]
        public CalculatorResponse Multiply(CalculatorRequest calculatorRequest)
        {
            var calculatorOperator = _operatorsFactory.CreateMultiplicationOperator();
            return GetCalculatorResponse(calculatorOperator, calculatorRequest);
        }

        private static CalculatorResponse GetCalculatorResponse(IOperator calculatorOperator, CalculatorRequest calculatorRequest)
        {
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