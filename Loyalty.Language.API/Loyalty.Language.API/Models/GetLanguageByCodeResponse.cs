namespace Loyalty.Language.API.Models
{
	public class GetLanguageByCodeResponse
	{
		public LocaleCodeResponse LocaleCode { get; set; }
		public string Name { get; set; }
		public int Order { get; set; }
		public bool AdminDefault { get; set; }
		public bool ApiDefault { get; set; }
		public List<TranslationResponse> Translations { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string CreatedBy { get; set; }
		public string UpdatedBy { get; set; }
	}
}
