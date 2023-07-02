using Microsoft.AspNetCore.Mvc;

namespace BurberBreakfast.Controllers;

public class ErrorCotroller : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}