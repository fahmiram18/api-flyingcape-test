using api_flyingcape_test.Interfaces;
using api_flyingcape_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_flyingcape_test.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PartnerController : Controller
{
    private IPartnerRepository _partnerRepository;

    public PartnerController(IPartnerRepository partnerRepository)
    {
        _partnerRepository = partnerRepository;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(IEnumerable<Partner>))]
    public IActionResult GetPartners([FromQuery] string keyword = "")
    {
        var data = _partnerRepository.GetPartners(keyword);

        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        return Ok(data);
    }
}