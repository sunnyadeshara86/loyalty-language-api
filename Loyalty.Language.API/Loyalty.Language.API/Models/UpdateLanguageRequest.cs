namespace Loyalty.Language.API.Models
{
	public class UpdateLanguageRequest
	{
		public string Name { get; set; }
		public string Code { get; set; }
		public bool AdminDefault { get; set; }
		public bool ApiDefault { get; set; }
		public int Order { get; set; }
	}
}
