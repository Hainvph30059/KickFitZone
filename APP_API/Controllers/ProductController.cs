using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _service;

		public ProductController(IProductService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<ColorDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = 1, [FromQuery] int? pageSize = 5)
		{
			if (!ModelState.IsValid)
			{
				return NotFound();
			}
			return Ok(await _service.GetAllAsync(pageNumber, pageSize));
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<ProductDto>), StatusCodes.Status200OK)]
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
		[ProducesResponseType(typeof(ProductDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var productDto = _service.GetByID(id);
			if (productDto == null)
				return NotFound(new { Mesage = "Color not found" });
			return Ok(productDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] ProductDto productDto)
		{
			if (_service.Create(productDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = productDto.ProductID }, productDto);
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
		public IActionResult Update([FromBody] ProductDto productDto)
		{
			if (!_service.Update(productDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
