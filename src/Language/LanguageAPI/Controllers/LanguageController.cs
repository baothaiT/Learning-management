using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanguageAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController : ControllerBase
{
    public LanguageController()
    {

    }

    [HttpGet]
    public IActionResult GetLanguages()
    {
        // This is a placeholder for the actual implementation.
        // You would typically fetch this data from a database or another service.
        var languages = new List<string> { "English", "Spanish", "French", "German" };
        return Ok(languages);
    }
}

