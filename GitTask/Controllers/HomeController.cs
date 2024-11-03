using Microsoft.AspNetCore.Mvc;

namespace GitTask.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    public IActionResult GetWord()
    {
        return Ok("Salam");
    }

    public IActionResult GetWord2()
    {
        return Ok("Sagol");
    }
}
