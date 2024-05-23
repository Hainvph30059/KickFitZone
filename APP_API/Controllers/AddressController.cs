using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddressController : ControllerBase
	{
		
		private readonly IAddressService _service;

		public AddressController(IAddressService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<AddressDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 5)
		{
			if (!ModelState.IsValid)
			{
				return NotFound();
			}
			return Ok(await _service.GetAllAsync(pageNumber, pageSize));
		}
	}
}
