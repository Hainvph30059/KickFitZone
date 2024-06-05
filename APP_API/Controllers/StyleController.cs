using APP_DATA.ClassDTO;
using APP_Service.Repositories.Interfaces;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StyleController : ControllerBase
	{
		private readonly IStyleService _service;

		public StyleController(IStyleService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<StyleDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var styles = await _service.GetAllAsync(pageNumber, pageSize);

			if (styles == null || !styles.Any())
			{
				return NotFound(new { Message = "No style found." });
			}

			return Ok(styles);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<StyleDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var styles = _service.Find(keyword);
			if (!styles.Any())
			{
				return NotFound(new { Message = "No style found for the given keyword." });
			}

			return Ok(styles);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(StyleDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var styleDto = _service.GetByID(id);
			if (styleDto == null)
				return NotFound(new { Mesage = "Style not found" });
			return Ok(styleDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] StyleDto styleDto)
		{
			if (_service.Create(styleDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = styleDto.StyleID }, styleDto);
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
				return BadRequest(new { Message = "Style not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] StyleDto styleDto)
		{
			if (!_service.Update(styleDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
