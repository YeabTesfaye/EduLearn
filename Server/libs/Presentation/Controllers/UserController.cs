using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    public UserController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = _serviceManager.UserService.GetAllUsers(trackChanges: false);
        return Ok(users);
    }
}
