namespace Loyalty.Language.API.Models
{
	public class LanguageItemResponse
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public bool AdminDefault { get; set; }
		public bool ApiDefault { get; set; }
		public int Order { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
