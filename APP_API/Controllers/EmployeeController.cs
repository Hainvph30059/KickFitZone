using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService _service;

		public EmployeeController(IEmployeeService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<EmployeeDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var employees = await _service.GetAllAsync(pageNumber, pageSize);

			if (employees == null || !employees.Any())
			{
				return NotFound(new { Message = "No employee found." });
			}

			return Ok(employees);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<EmployeeDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var employees = _service.Find(keyword);
			if (!employees.Any())
			{
				return NotFound(new { Message = "No employee found for the given keyword." });
			}

			return Ok(employees);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(EmployeeDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var employeeDto = _service.GetByID(id);
			if (employeeDto == null)
				return NotFound(new { Mesage = "Employee not found" });
			return Ok(employeeDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] EmployeeDto employeeDto)
		{
			if (_service.Create(employeeDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = employeeDto.EmployeeID }, employeeDto);
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
				return BadRequest(new { Message = "Employee not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] EmployeeDto employeeDto)
		{
			if (!_service.Update(employeeDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
