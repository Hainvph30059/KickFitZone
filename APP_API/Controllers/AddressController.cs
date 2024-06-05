using APP_DATA.ClassDTO;
using APP_Service.Services.Implementations;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

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
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var addresses = await _service.GetAllAsync(pageNumber, pageSize);

			if (addresses == null || !addresses.Any())
			{
				return NotFound(new { Message = "No addresses found." });
			}

			return Ok(addresses);
		}
		[HttpGet("streetname")]
		[ProducesResponseType(typeof(IEnumerable<AddressDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var addresses = _service.Find(keyword);
			if (!addresses.Any())
			{
				return NotFound(new { Message = "No addresses found for the given keyword." });
			}

			return Ok(addresses);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(AddressDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var addressDto = _service.GetByID(id);
			if (addressDto == null)
				return NotFound(new { Mesage = "Addresses not found" });
			return Ok(addressDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] AddressDto addressDto)
		{
			if (_service.Create(addressDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = addressDto.AddressID }, addressDto);
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
				return BadRequest(new { Message = "Address not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] AddressDto addressDto)
		{
			if (!_service.Update(addressDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
