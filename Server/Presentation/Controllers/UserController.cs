using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<string> { "Alice", "Bob", "Charlie" };
            return Ok(users);
        }
    }
}
