using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoleController : ControllerBase
	{
		private readonly IRoleService _service;

		public RoleController(IRoleService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<RoleDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var roles = await _service.GetAllAsync(pageNumber, pageSize);

			if (roles == null || !roles.Any())
			{
				return NotFound(new { Message = "No role found." });
			}

			return Ok(roles);
		}
		[HttpGet("name")]
		[ProducesResponseType(typeof(IEnumerable<RoleDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var roles = _service.Find(keyword);
			if (!roles.Any())
			{
				return NotFound(new { Message = "No role found for the given keyword." });
			}

			return Ok(roles);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(RoleDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var roleDto = _service.GetByID(id);
			if (roleDto == null)
				return NotFound(new { Mesage = "Role not found" });
			return Ok(roleDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] RoleDto roleDto)
		{
			if (_service.Create(roleDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = roleDto.RoleID }, roleDto);
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
				return BadRequest(new { Message = "Role not found or could not be deleted." });
			}
			return NoContent();
		}
		[HttpPut]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Update([FromBody] RoleDto roleDto)
		{
			if (!_service.Update(roleDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
