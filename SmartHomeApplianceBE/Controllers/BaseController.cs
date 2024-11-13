using Microsoft.AspNetCore.Mvc;

namespace SmartHomeAppliance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected string UserId => User.Identity!.IsAuthenticated ? User.Claims.First().Value : string.Empty;
    }
}
