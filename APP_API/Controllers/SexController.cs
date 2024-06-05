using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SexController : ControllerBase
	{
		private readonly ISexService _service;

		public SexController(ISexService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<SexDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var sexess = await _service.GetAllAsync(pageNumber, pageSize);

			if (sexess == null || !sexess.Any())
			{
				return NotFound(new { Message = "No sexes found." });
			}

			return Ok(sexess);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<SexDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var sexess = _service.Find(keyword);
			if (!sexess.Any())
			{
				return NotFound(new { Message = "No sexes found for the given keyword." });
			}

			return Ok(sexess);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(SexDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var sexDto = _service.GetByID(id);
			if (sexDto == null)
				return NotFound(new { Mesage = "Sex not found" });
			return Ok(sexDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] SexDto sexDto)
		{
			if (_service.Create(sexDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = sexDto.SexID }, sexDto);
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
				return BadRequest(new { Message = "Sex not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] SexDto sexDto)
		{
			if (!_service.Update(sexDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
