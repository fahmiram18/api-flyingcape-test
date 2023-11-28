using api_flyingcape_test.Interfaces;
using api_flyingcape_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_flyingcape_test.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : Controller
{
    private ICourseRepository _courseRepository;

    public CourseController(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Course>))]
    public IActionResult GetCourses([FromQuery] string keyword = "", [FromQuery] int typeId = 0)
    {
        var data = _courseRepository.GetCourses(keyword, typeId);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(data);
    }
}