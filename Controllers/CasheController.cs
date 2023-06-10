using CasheApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasheApplication.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CasheController : ControllerBase
{
    private readonly CasheService _service;

    public CasheController(CasheService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Add(int a, int b)
    {
        int result = a + b;
        await Task.Delay(5000);
        return Ok(result);
    }

    [HttpPost("cashe")]
    public async Task<IActionResult> Add2(int a, int b)
    {
        var key = $"{a},{b}";

        int result = a + b;

        if(_service.Get(key, out var value))
        {
            return Ok(value);
        }
        
         _service.Set(key, result);    

        await Task.Delay(5000);

        return Ok(result);

    }

}
