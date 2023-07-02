namespace Loyalty.Language.API.Models
{
	public class ValidationResponse
	{
		public string Message { get; set; }
		public List<string> Parameters { get; set; }
		public string Plural { get; set; }
		public string Code { get; set; }
		public string Path { get; set; }
	}
}
