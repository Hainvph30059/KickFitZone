using APP_DATA.ClassDTO;
using APP_Service.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VouchersController : ControllerBase
	{
		private readonly IVoucherService _service;

		public VouchersController(IVoucherService service)
		{
			_service = service;
		}
		[HttpGet]
		[ProducesResponseType(typeof(IEnumerable<VouchersDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetAll([FromQuery] int? pageNumber = null, [FromQuery] int? pageSize = null)
		{
			var vouchers = await _service.GetAllAsync(pageNumber, pageSize);

			if (vouchers == null || !vouchers.Any())
			{
				return NotFound(new { Message = "No voucher found." });
			}

			return Ok(vouchers);
		}
		[HttpGet("code")]
		[ProducesResponseType(typeof(IEnumerable<VouchersDto>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Find([FromQuery] string keyword)
		{
			var vouchers = _service.Find(keyword);
			if (!vouchers.Any())
			{
				return NotFound(new { Message = "No voucher found for the given keyword." });
			}

			return Ok(vouchers);
		}
		[HttpGet("{id}")]
		[ProducesResponseType(typeof(VouchersDto), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult GetByID([FromRoute] Guid id)
		{
			var vouchersDto = _service.GetByID(id);
			if (vouchersDto == null)
				return NotFound(new { Mesage = "Color not found" });
			return Ok(vouchersDto);
		}
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult Create([FromBody] VouchersDto vouchersDto)
		{
			if (_service.Create(vouchersDto))
			{
				return CreatedAtAction(nameof(GetByID), new { id = vouchersDto.VoucherID }, vouchersDto);
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
		public IActionResult Update([FromBody] VouchersDto vouchersDto)
		{
			if (!_service.Update(vouchersDto))
			{
				return BadRequest();
			}
			return NoContent();
		}
	}
}
