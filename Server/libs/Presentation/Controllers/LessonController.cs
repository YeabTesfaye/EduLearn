using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("api/lessons")]
[ApiController]
public class LessonController : ControllerBase
{
  private readonly IServiceManager _serviceManager;
  public LessonController(IServiceManager serviceManager)
  {
    _serviceManager = serviceManager;
  }


  [HttpGet]
  public IActionResult GetAllLessons()
  {
    try
    {
      var lessons = _serviceManager.LessonService.GetAllLessons(trackChanges: true);
      return Ok(lessons);
    }
    catch
    {

      return StatusCode(500, "Internal server error");
    }
  }
}
