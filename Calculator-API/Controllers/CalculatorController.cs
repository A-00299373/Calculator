using Microsoft.AspNetCore.Mvc;

namespace CalcAPI.Controllers;


[ApiController]
[Route("[controller]/[action]")]

public class CalculatorController : ControllerBase
{

    private string GetResultMessage(decimal result, string operation)
    {
        return $"Result: = {result} \nOperation performed:{operation}";
    }
    
    [HttpGet]
    public string Add(decimal num1, decimal num2)
    {
        return GetResultMessage(num1 + num2, "Addition");
    }

    [HttpGet]
    public string Subtract(decimal num1, decimal num2)
    {
        return GetResultMessage(num1 - num2, "Subtraction");
    }

    [HttpGet]
    public string Multiply(decimal num1, decimal num2)
    {
        return GetResultMessage(num1 * num2, "Multiplication");
    }

    [HttpGet]
    public string Divide(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            return "Cannot divide by zero.";
        }
            return GetResultMessage(num1 / num2, "Division");
    }

    [HttpGet]
    public string Quotient(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            return "Cannot calculate quotient with zero divisor.";
        }
        return GetResultMessage(num1 %  num2, "Division");
    }
}
