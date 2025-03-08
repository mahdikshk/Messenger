using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("Login")]
        public async Task<IActionResult> Login(LoginRequest request,CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
