using APP_DATA.Entites;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		IAuthService _service;

		public AuthController(IAuthService service)
		{
			_service = service;
		}

		[HttpPost("login")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status401Unauthorized)]
		public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
		{
		  var result =_service.Login(loginRequest);
			if(result == string.Empty)
			{
				return Unauthorized("Invalid username or password.");
			}
			return Ok(new { Token = result });
		}
	}
}
