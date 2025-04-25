using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Presentation.Controllers;

[Route("/api/courses")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly IServiceManager _serviceManager;

    public CourseController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    [HttpGet]
    public IActionResult GetAllCourse()
    {
        try
        {
            var courses = _serviceManager.CourseService.GetAllCourses(trackChanges: false);
            return Ok(courses);
        }
        catch
        {
            return StatusCode(500, "Internal server error");

        }
    }
}
