using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BillController : ControllerBase
	{
		private readonly IBillService _service;

		public BillController(IBillService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<BillDto>), StatusCodes.Status200OK)]
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
