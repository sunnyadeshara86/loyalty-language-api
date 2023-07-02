namespace Loyalty.Language.API.Models
{
	public class ValidationErrorResponse : ErrorResponse
	{
		public List<ValidationResponse> Errors { get; set; }
	}
}
