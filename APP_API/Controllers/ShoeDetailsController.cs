using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ShoeDetailsController : ControllerBase
	{
		private readonly IShoeDetailsService _service;

		public ShoeDetailsController(IShoeDetailsService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<ShoesDetailsDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 5)
		{
			var shoesDetails = await _service.GetAllAsync(pageNumber, pageSize);

			if (shoesDetails == null || !shoesDetails.Any())
			{
				return NotFound(new { Message = "No shoesDetail found." });
			}

			return Ok(shoesDetails);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<ShoesDetailsDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var shoesDetails = _service.Find(keyword);
			if (!shoesDetails.Any())
			{
				return NotFound(new { Message = "No shoesDetail found for the given keyword." });
			}

			return Ok(shoesDetails);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(ShoesDetailsDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var shoesDetailsDto = _service.GetByID(id);
			if (shoesDetailsDto == null)
				return NotFound(new { Mesage = "ShoesDetail not found" });
			return Ok(shoesDetailsDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] ShoesDetailsDto shoesDetailsDto)
		{
			if (_service.Create(shoesDetailsDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = shoesDetailsDto.ShoesDetailsID }, shoesDetailsDto);
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
				return BadRequest(new { Message = "ShoesDetail not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] ShoesDetailsDto shoesDetailsDto)
		{
			if (!_service.Update(shoesDetailsDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
