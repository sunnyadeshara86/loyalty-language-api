namespace Loyalty.Language.API.Models
{
	public class ManageTranslationRequest
	{
		public string LanguageCode { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
	}
}
