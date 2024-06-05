using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ColorController : ControllerBase
	{
		private readonly IColorService _service;

		public ColorController(IColorService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<ColorDto>), StatusCodes.Status200OK)]
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
		[ProducesResponseType(typeof(IEnumerable<ColorDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var colors = _service.Find(keyword);
			if (!colors.Any())
			{
				return NotFound(new { Message = "No color found for the given keyword." });
			}

			return Ok(colors);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(ColorDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var colorDto = _service.GetByID(id);
			if (colorDto == null)
				return NotFound(new { Mesage = "Color not found" });
			return Ok(colorDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] ColorDto colorDto)
		{
			if (_service.Create(colorDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = colorDto.ColorID }, colorDto);
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
				return BadRequest(new { Message = "Color not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] ColorDto colorDto)
		{
			if (!_service.Update(colorDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
