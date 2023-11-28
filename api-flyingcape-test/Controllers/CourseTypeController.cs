using api_flyingcape_test.Interfaces;
using api_flyingcape_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_flyingcape_test.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseTypeController : Controller
{
    private ICourseTypeRepository _courseTypeRepository;
    
    public CourseTypeController(ICourseTypeRepository courseTypeRepository)
    {
        _courseTypeRepository = courseTypeRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<CourseType>))]
    public IActionResult GetCourseType()
    {
        var data = _courseTypeRepository.GetCourseTypes();

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(data);
    }
}