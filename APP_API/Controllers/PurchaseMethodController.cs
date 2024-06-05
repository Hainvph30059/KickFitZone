using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PurchaseMethodController : ControllerBase
	{
		private readonly IPurcharMethodService _service;

		public PurchaseMethodController(IPurcharMethodService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<PurchaseMethodDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var colors = await _service.GetAllAsync(pageNumber, pageSize);

			if (colors == null || !colors.Any())
			{
				return NotFound(new { Message = "No color found." });
			}

			return Ok(colors);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<PurchaseMethodDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var colors = _service.Find(keyword);
			if (!colors.Any())
			{
				return NotFound(new { Message = "No PurchaseMethod found for the given keyword." });
			}

			return Ok(colors);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(PurchaseMethodDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var purchaseMethodDto = _service.GetByID(id);
			if (purchaseMethodDto == null)
				return NotFound(new { Mesage = "PurchaseMethod not found" });
			return Ok(purchaseMethodDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] PurchaseMethodDto purchaseMethodDto)
		{
			if (_service.Create(purchaseMethodDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = purchaseMethodDto.PurchaseMethodID }, purchaseMethodDto);
			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Delete([FromRoute] Guid id)
		{
			if (!_service.Delete(id))
			{
				return BadRequest(new { Message = "PurchaseMethod not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] PurchaseMethodDto purchaseMethodDto)
		{
			if (!_service.Update(purchaseMethodDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
