using Microsoft.AspNetCore.Mvc;

namespace CalcAPI.Controllers;


[ApiController]
[Route("[controller]/[action]")]

public class CalculatorController : ControllerBase
{
    [HttpGet]
    public decimal Add(decimal num1, decimal num2)
    {
        decimal result = num1 + num2;
        return result;
    }

    [HttpGet]
    public decimal Subtract(decimal num1, decimal num2)
    {
        decimal result = num1 - num2;
        return result;
    }

    [HttpGet]
    public decimal Multiply(decimal num1, decimal num2)
    {
        decimal result = num1 * num2;
        return result;
    }

    [HttpGet]
    public ActionResult Divide(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            return BadRequest("Cannot divide by zero.");
        }

        decimal result = num1 / num2;
        return Ok(result);
    }

    [HttpGet]
    public ActionResult Quotient(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            return BadRequest("Cannot calculate quotient with zero divisor.");
        }

        decimal remainder = num1 % num2;
        return Ok(remainder);
    }
}
