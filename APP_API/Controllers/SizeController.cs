using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SizeController : ControllerBase
	{
		private readonly ISizeService _service;

		public SizeController(ISizeService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<SizeDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var Sizess = await _service.GetAllAsync(pageNumber, pageSize);

			if (Sizess == null || !Sizess.Any())
			{
				return NotFound(new { Message = "No Sizes found." });
			}

			return Ok(Sizess);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<SizeDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var Sizess = _service.Find(keyword);
			if (!Sizess.Any())
			{
				return NotFound(new { Message = "No Sizes found for the given keyword." });
			}

			return Ok(Sizess);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(SizeDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var sizeDto = _service.GetByID(id);
			if (sizeDto == null)
				return NotFound(new { Mesage = "Size not found" });
			return Ok(sizeDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] SizeDto sizeDto)
		{
			if (_service.Create(sizeDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = sizeDto.SizeID }, sizeDto);
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
				return BadRequest(new { Message = "Size not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] SizeDto sizeDto)
		{
			if (!_service.Update(sizeDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
