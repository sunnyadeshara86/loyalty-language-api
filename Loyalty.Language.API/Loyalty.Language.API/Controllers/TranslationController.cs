using Loyalty.Language.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loyalty.Language.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TranslationController : ControllerBase
	{
		#region Private Members

		private readonly ILogger<TranslationController> _logger;

		#endregion

		#region Constructors

		public TranslationController(ILogger<TranslationController> logger)
		{
			_logger = logger;
		}

		#endregion

		#region Get Methods

		[HttpGet]
		[Route("{locale}")]
		[ProducesResponseType(200, Type = typeof(Dictionary<string, string>))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		[ProducesResponseType(404, Type = typeof(ErrorResponse))]
		public IActionResult GetTrnslations(string locale)
		{
			return Ok(new Dictionary<string, string>());
		}

		#endregion
	}
}
