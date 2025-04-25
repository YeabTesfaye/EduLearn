using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("/api/modules")]
[ApiController]
public class ModuleController  : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public ModuleController(IServiceManager serviceManager)
    {
        _serviceManager  = serviceManager;
    }

    [HttpGet]
    public IActionResult GetAllModlue(){
        
        return Ok();
    }
}
