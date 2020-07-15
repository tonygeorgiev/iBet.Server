namespace iBet.Server.Controllers.Base
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("/api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
