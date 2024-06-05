using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MaterialController : ControllerBase
	{
		private readonly IMaterialService _service;

		public MaterialController(IMaterialService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<MaterialDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var Materialss = await _service.GetAllAsync(pageNumber, pageSize);

			if (Materialss == null || !Materialss.Any())
			{
				return NotFound(new { Message = "No Materials found." });
			}

			return Ok(Materialss);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<MaterialDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var Materialss = _service.Find(keyword);
			if (!Materialss.Any())
			{
				return NotFound(new { Message = "No Materials found for the given keyword." });
			}

			return Ok(Materialss);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(MaterialDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var materialDto = _service.GetByID(id);
			if (materialDto == null)
				return NotFound(new { Mesage = "Material not found" });
			return Ok(materialDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] MaterialDto materialDto)
		{
			if (_service.Create(materialDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = materialDto.MaterialID }, materialDto);
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
		public IActionResult Update([FromBody] MaterialDto materialDto)
		{
			if (!_service.Update(materialDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
