using Loyalty.Language.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loyalty.Language.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LanguageController : ControllerBase
	{
		#region Private Members

		private readonly ILogger<LanguageController> _logger;

		#endregion

		#region Constructors

		public LanguageController(ILogger<LanguageController> logger)
		{
			_logger = logger;
		}

		#endregion

		#region Get Methods

		[HttpGet]
		[Route("{code}")]
		[ProducesResponseType(200, Type = typeof(GetLanguageByCodeResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]

		public IActionResult GetLanguageByCode(string code)
		{
			return Ok();
		}

		[HttpGet]
		[ProducesResponseType(200, Type = typeof(GetLanguagesResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult GetLanguages(GetLanguagesRequest getLanguagesRequest) 
		{
			return Ok(new GetLanguagesResponse());
		}

		#endregion

		#region Post Methods

		[HttpPost]
		[ProducesResponseType(204)]
		[ProducesResponseType(400, Type = typeof(ValidationErrorResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult CreateLanguage(CreateLanguageRequest createLanguageRequest)
		{
			return NoContent();
		}

		#endregion

		#region Put Methods

		[HttpPut]
		[Route("{code}")]
		[ProducesResponseType(204)]
		[ProducesResponseType(400, Type = typeof(ValidationErrorResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult UpdateLanguage(UpdateLanguageRequest updateLanguageRequest)
		{
			return NoContent();
		}

		#endregion

		#region Delete Methods

		[HttpDelete]
		[Route("{code}")]
		[ProducesResponseType(204)]
		[ProducesResponseType(400, Type = typeof(ValidationErrorResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult DeleteLanguage(string code)
		{
			return NoContent();
		}

		#endregion
	}
}
