using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public IActionResult SubmitContact([FromBody] ContactInfo contactInfo)
        {
            // Process the contact info (e.g., save to a database, send an email, etc.)
            // ...

            // Return a success message
            return Ok("Contact information submitted successfully!");
        }
    }
}
