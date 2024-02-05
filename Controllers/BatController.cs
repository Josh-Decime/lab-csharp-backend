

namespace dotnetBats.Controllers;

[ApiController]
[Route("api/bats")]
public class BatController : ControllerBase
{
    private readonly BatService batService;
}