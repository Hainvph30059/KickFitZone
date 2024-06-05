using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _service;

		public CustomerController(ICustomerService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<CustomerDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var customers = await _service.GetAllAsync(pageNumber, pageSize);

			if (customers == null || !customers.Any())
			{
				return NotFound(new { Message = "No customer found." });
			}

			return Ok(customers);
		}
		[HttpGet("fullname")]
		[ProducesResponseType(typeof(IEnumerable<CustomerDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var customers = _service.Find(keyword);
			if (!customers.Any())
			{
				return NotFound(new { Message = "No customer found for the given keyword." });
			}

			return Ok(customers);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(CustomerDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var customerDto = _service.GetByID(id);
			if (customerDto == null)
				return NotFound(new { Mesage = "Customer not found" });
			return Ok(customerDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] CustomerDto customerDto)
		{
			if (_service.Create(customerDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = customerDto.CustomerID }, customerDto);
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
				return BadRequest(new { Message = "Customer not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] CustomerDto customerDto)
		{
			if (!_service.Update(customerDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
