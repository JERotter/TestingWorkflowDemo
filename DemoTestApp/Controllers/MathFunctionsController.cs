using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoTestApp.Controllers;


[ApiController]
[Route("api/[controller]")]
public class MathFunctionsController : ControllerBase
{
    public readonly IMathFunctionsService _mathFunctionsService;

    public MathFunctionsController(IMathFunctionsService mathFunctionsService)
    {
        _mathFunctionsService = mathFunctionsService;
    }

    [HttpPost("add")]
    public int AddNumbers(int a, int b)
    {
        var result = _mathFunctionsService.AddNumbers(a,b);
        return result;
    }
}