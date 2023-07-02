namespace Loyalty.Language.API.Models
{
	public class GetLanguagesResponse
	{
        public List<LanguageItemResponse> Items { get; set; }
        public SummaryResponse Total { get; set; }
    }
}
